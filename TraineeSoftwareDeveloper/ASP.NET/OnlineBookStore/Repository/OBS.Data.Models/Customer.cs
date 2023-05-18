namespace OBS.Data.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Order>? Orders { get; set; }

    }
}