using RestaurantMVCNET.Models;

namespace RestaurantMVCNET.Data
{
    public class DbInitializer
    {
        public static async Task Initialize(MvcRestaurantContext context)
        {

            if (context.Restaurants.Any())
            {
                return;
            }

            var restaurants = new Restaurant[]
            {
                new Restaurant { Name = "Forni Rossi", Description="desc1", Address="adres1", Capacity=2, Email="edwdwd@ewew.lp", PhoneNumber="342432442", Tables=null},
                
            };

            await context.Restaurants.AddRangeAsync(restaurants);
            await context.SaveChangesAsync();
        }
    }
}
