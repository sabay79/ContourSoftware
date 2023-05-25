namespace OBS.Data.Models
{
    public class Publisher
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual ICollection<Book>? Books { get; set; }
    }
}