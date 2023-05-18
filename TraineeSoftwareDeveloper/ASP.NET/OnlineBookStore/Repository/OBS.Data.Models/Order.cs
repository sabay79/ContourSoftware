namespace OBS.Data.Models
{
    public class Order
    {
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int DeliveryCharges { get; set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
        public int OrderPrice()
        {
            var orderItemsPrice = 0;
            foreach (var item in OrderItems)
            {
                orderItemsPrice += item.Price();
            }
            return orderItemsPrice + DeliveryCharges;
        }
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