namespace OBS.Data.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}