namespace OBS.Business.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<OrderModel>? Orders { get; set; }

    }
}