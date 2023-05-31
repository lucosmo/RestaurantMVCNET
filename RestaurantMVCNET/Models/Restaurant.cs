namespace RestaurantMVCNET.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set;}

        public IEnumerable<Table> Tables { get; set; }
    }
}
