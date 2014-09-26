using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using vNextDemo.Models;

namespace vNextDemo
{
    public class Startup
    {
        public void Configure(IBuilder app)
        {

            //app.Use(async (ctx, next) =>
            // {
            //     try
            //     {
            //         await next();
            //     }
            //     catch (Exception ex)
            //     {
            //         ctx.Response.StatusCode = 500;
            //         await ctx.Response.WriteAsync(ex.Message);
            //     }
            // });

            //app.UseErrorPage();




            // Set up application services
            app.UseServices(services =>
            {
                services.AddSingleton<IBooksRepository, BooksRepository>();

                services.AddSingleton<IConfiguration, SiteConfiguration>();


                // Add MVC services to the services container
                services.AddMvc();
            });

            // Enable Browser Link support
            app.UseBrowserLink();

            // Add static files to the request pipeline
            app.UseStaticFiles();

            // Add MVC to the request pipeline
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Home", action = "Index" });

                routes.MapRoute(
                    name: "api",
                    template: "{controller}/{id?}");
            });
        }
    }
}
