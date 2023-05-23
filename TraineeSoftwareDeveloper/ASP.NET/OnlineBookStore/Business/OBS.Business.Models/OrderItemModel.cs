namespace OBS.Business.Models
{
    public class OrderItemModel
    {
        public int ID { get; set; }

        public int OrderID { get; set; }
        public OrderModel Order { get; set; }

        public int BookID { get; set; }
        public BookModel Book { get; set; }

        public int Quantity { get; set; }
        public int Price() => Quantity * Book.Price;

    }
}