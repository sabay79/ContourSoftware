namespace OBS.Data.Models
{
    public class AuthorBook
    {
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
        public int BookID { get; set; }
        public virtual Book Book { get; set; }
    }
}
