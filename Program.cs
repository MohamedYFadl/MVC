using Microsoft.AspNetCore.Mvc;
using System;

namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
            app.UseStaticFiles();
            //app.MapGet("/", () => "Hello World!");

            app.UseRouting();
            //app.Use(async (context, next) => {
            //    Endpoint endpoint = context.GetEndpoint();
            //    if (endpoint != null)
            //        await context.Response.WriteAsync(endpoint.DisplayName);

            //    await next(context);

            //});
            //app.UseEndpoints(endPoint =>
            //{

            //    endPoint.Map("/", async (context) =>
            //    {
            //        await context.Response.WriteAsync("Your are in Default Page ");
            //    });

            //    endPoint.Map("/Home", async (context) =>
            //    {
            //        await context.Response.WriteAsync("Your are in Home Page ");
            //    });

            //    endPoint.MapGet("/Products", async (context) =>
            //    {
            //        await context.Response.WriteAsync("Your are in Products Page ");
            //    });
            //    endPoint.MapPost("/Products", async (context) =>
            //    {
            //        await context.Response.WriteAsync("Products Has been Created!");
            //    });
            //});
            app.UseEndpoints(endPoint =>
            {

                //endPoint.Map("/", async (context) =>
                //{
                //    await context.Response.WriteAsync("Your are in Default Page ");
                //});


                ////endPoint.MapGet("/Products", async (context) =>
                ////{
                ////    await context.Response.WriteAsync("You Are in Products Page");
                ////});
                //endPoint.MapGet("/Products/{id=100}", async (context) =>
                //{
                //    var id = context.Request.RouteValues["id"];
                //    if (id != null) {
                //        id = Convert.ToInt32(context.Request.RouteValues["id"]);
                //        await context.Response.WriteAsync($"Your getting Product with {id}");

                //    }
                //    else
                //        await context.Response.WriteAsync("You Are in Products Page");

                //});
                //endPoint.MapGet("/Books/Author/authorName={authorName:alpha:minlength(4):maxlength(10)}/bookId={bookId}", async (context) =>
                //{
                //    var bookId = Convert.ToInt32(context.Request.RouteValues["bookId"]);
                //    var authorName = Convert.ToString(context.Request.RouteValues["authorName"]);
                //    await context.Response.WriteAsync($"Your getting Product with {bookId} and Author : {authorName}");
                //});
                endPoint.MapControllerRoute(
                    name:"Default",
                    pattern:"/{controller=Home}/{action=Index}",
                    defaults: new { controller="Home", action= "Index" }
                    );
            });

            //app.Run(async (HttpContext context) =>
            //{
            //    await context.Response.WriteAsync("The Page is NOt Found");

            //});
            app.Run();
        }
    }
}
