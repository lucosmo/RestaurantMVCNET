using Microsoft.EntityFrameworkCore;
using RestaurantMVCNET.Data;

namespace RestaurantMVCNET
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MvcRestaurantContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcRestaurantContext")));
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();

        }
    }
}