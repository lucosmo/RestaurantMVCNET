namespace RestaurantMVCNET.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public Customer MainCustomer { get; set; }
        public string NumberOfPeople { get; set; }
        public DateTime TimeOfReservation { get; set; }
        public string Comments { get; set; }

    }
}
