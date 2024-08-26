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
                endPoint.Map("/Home", async (context) =>
                {
                    await context.Response.WriteAsync("Your are in Home Page");
                });
            });

            app.Run();
        }
    }
}
