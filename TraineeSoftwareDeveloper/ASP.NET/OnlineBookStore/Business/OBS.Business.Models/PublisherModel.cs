namespace OBS.Business.Models
{
    public class PublisherModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<BookModel>? Books { get; set; }
    }
}