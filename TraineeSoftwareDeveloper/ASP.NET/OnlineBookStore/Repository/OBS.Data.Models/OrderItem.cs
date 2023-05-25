namespace OBS.Data.Models
{
    public class OrderItem
    {
        public int ID { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        public int BookID { get; set; }
        public virtual Book Book { get; set; }

        public int Quantity { get; set; }
        public int Price() => Quantity * Book.Price;

    }
}