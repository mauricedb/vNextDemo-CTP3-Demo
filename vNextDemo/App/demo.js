$(function () {

    $.getJSON("/books").then(function (books) {
        var parent = $("#books");

        books.forEach(function (book) {
            console.log(book);

            var element = $("<div>")
                .append($("<span>").text(book.Title))
                .append($("<br>"))
                .append($("<img>").attr("src", "/Images/" + book.ImageName))
                .appendTo(parent);
        });
    });

});