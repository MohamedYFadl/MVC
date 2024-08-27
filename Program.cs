namespace MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

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

                endPoint.Map("/", async (context) =>
                {
                    await context.Response.WriteAsync("Your are in Default Page ");
                });


                endPoint.MapGet("/Products", async (context) =>
                {
                    await context.Response.WriteAsync("Products Has been Created!");
                });
                endPoint.MapGet("/Products/Id={id}", async (context) =>
                {
                    var id = Convert.ToInt32(context.Request.RouteValues["id"]);
                    await context.Response.WriteAsync($"Your getting Product with {id}");
                });
                endPoint.MapGet("/Books/Author/{authorName}/{bookId}", async (context) =>
                {
                    var bookId = Convert.ToInt32(context.Request.RouteValues["bookId"]);
                    var authorName = Convert.ToString(context.Request.RouteValues["authorName"]);
                    await context.Response.WriteAsync($"Your getting Product with {bookId} and Author : {authorName}");
                });
            });

            app.Run(async (HttpContext context) =>
            {
                await context.Response.WriteAsync("The Page is NOt Found");

            });
            app.Run();
        }
    }
}
