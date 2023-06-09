using Microsoft.EntityFrameworkCore;
using RestaurantMVCNET.Data;
using RestaurantMVCNET.Models;

namespace RestaurantMVCNET.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly MvcRestaurantContext _context;

        public RestaurantService(MvcRestaurantContext context)
        {
            _context = context;
        }
        public Task AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public async Task AddRestaurant(Restaurant restaurant)
        {
            await _context.Restaurants.AddAsync(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurants()
        {
            return await _context.Restaurants.OrderBy(x => x.Name).ToListAsync();
        }

        public Task<Customer> GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Reservation> GetReservation(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Reservation>> GetReservationList()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Reservation>> GetReservationListByDate(DateTime time)
        {
            throw new NotImplementedException();
        }

        public async Task<Restaurant> GetRestaurant(int id)
        {
            return await _context.Restaurants.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task<Table> GetTable(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveReservation(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveTable(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task UpdateReservation(Reservation reservation)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRestuarant(Restaurant restaurant)
        {
            throw new NotImplementedException();
        }

        public Task UpdateTable(Table table)
        {
            throw new NotImplementedException();
        }
    }
}
