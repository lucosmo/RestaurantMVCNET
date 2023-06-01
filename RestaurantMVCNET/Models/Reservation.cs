namespace RestaurantMVCNET.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public int CustomerId { get; set; }
        public int TableId { get; set; }
        public Customer Customer { get; set; }
        public string NumberOfPeople { get; set; }
        public DateTime TimeOfReservation { get; set; }
        public string Comments { get; set; }

    }
}
