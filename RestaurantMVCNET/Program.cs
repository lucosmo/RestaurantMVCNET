using Microsoft.EntityFrameworkCore;
using RestaurantMVCNET.Data;
using RestaurantMVCNET.Services;

namespace RestaurantMVCNET
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<MvcRestaurantContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcRestaurantContext")), ServiceLifetime.Transient);

            builder.Services.AddTransient<IRestaurantService, RestaurantService>();

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var context = services.GetRequiredService<MvcRestaurantContext>();
                context.Database.EnsureCreated();
                await DbInitializer.Initialize(context);
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Restaurant}/{action=Index}/{id?}");

            app.Run();

        }
    }
}