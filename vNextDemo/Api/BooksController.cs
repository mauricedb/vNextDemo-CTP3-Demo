using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using vNextDemo.Models;

namespace vNextDemo.Api
{
    public class BooksController : Controller
    {
        private IBooksRepository _repo;

        public BooksController(IBooksRepository repo)
        {
            _repo = repo;
        }

        // GET api/books
        public IQueryable<Book> Get()
        {
            return _repo.GetBooks().AsQueryable();
        }

        // GET api/books/5
        //public Book Get(int id)
        //{
        //    var book = _repo.GetBook(id);

        //    return book;
        //}

        // GET api/books/5
        public IActionResult Get(int id)
        {
            var book = _repo.GetBook(id);
            if (book == null)
            {
                return HttpNotFound();
            }

            return Json(book);
        }

    }
}
