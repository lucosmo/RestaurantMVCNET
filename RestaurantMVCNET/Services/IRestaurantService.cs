using RestaurantMVCNET.Models;

namespace RestaurantMVCNET.Services
{
    public interface IRestaurantService
    {
        Task<Restaurant> GetRestaurant(int id);
        Task AddRestaurant(Restaurant restaurant);
        Task RemoveRestaurant(int id);
        Task UpdateRestuarant(Restaurant restaurant);
        Task<Customer> GetCustomer(int id);
        Task AddCustomer(Customer customer);
        Task RemoveCustomer(int id);
        Task UpdateCustomer(Customer customer);
        Task<Table> GetTable(int id);
        Task UpdateTable(Table table);
        Task RemoveTable(int id);
        Task<Reservation> GetReservation(int id);
        Task<IEnumerable<Reservation>> GetReservationList();
        Task<IEnumerable<Reservation>> GetReservationListByDate(DateTime time);
        Task UpdateReservation(Reservation reservation);
        Task RemoveReservation(int id);



    }
}
