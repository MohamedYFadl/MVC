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
            app.UseEndpoints(endPoint => {

                endPoint.Map("/", async (context) =>
                {
                    await context.Response.WriteAsync("Your are in Default Page ");
                });

                endPoint.Map("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("Your are in Home Page ");
                });

                endPoint.MapGet("/Products", async (context) =>
                {
                    await context.Response.WriteAsync("Your are in Products Page ");
                });
                endPoint.MapPost("/Products", async (context) =>
                {
                    await context.Response.WriteAsync("Products Has been Created!");
                });
            });


            app.Run(async (HttpContext context)=> {
                await context.Response.WriteAsync("The Page is NOt Found");
            
            });
            app.Run();
        }
    }
}
