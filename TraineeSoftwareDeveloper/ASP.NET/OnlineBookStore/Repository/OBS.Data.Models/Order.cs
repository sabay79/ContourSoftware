namespace OBS.Data.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime Orderdate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DeliveryCharges { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }

    public enum PaymentMethod : byte
    {
        CashOnDelivery,
        BankTransfer
    }

    public enum OrderStatus : byte
    {
        Cancelled,
        Pending,
        Shipped,
        Delivered
    }
}