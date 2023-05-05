namespace EntityFramework.Model
{
    public class Author
    {
        public Author(string name)
        {
            Name = name;
        }
        public int ID { get; private set; }
        public string Name { get; set; }
        public ContactDetails Contact { get; set; } = null!;
        public List<Post> Posts { get; } = new();
    }
}