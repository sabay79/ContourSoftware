namespace OBS.Business.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int ISBN { get; set; }
        public int Price { get; set; }
        public DateTime Year { get; set; }

        public ICollection<AuthorModel> Authors { get; set; }

        public int PublisherID { get; set; }
        public Publisher Publisher { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}