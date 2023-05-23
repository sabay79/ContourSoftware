namespace OBS.Business.Models
{
    public class AuthorModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }

        public ICollection<BookModel> Books { get; set; }
    }
}