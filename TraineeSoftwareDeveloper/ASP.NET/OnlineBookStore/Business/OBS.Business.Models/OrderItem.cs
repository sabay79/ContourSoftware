namespace OBS.Business.Models
{
    public class OrderItem
    {
        public int ID { get; set; }

        public int OrderID { get; set; }
        public Order Order { get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }

        public int Quantity { get; set; }
        public int Price() => Quantity * Book.Price;

    }
}