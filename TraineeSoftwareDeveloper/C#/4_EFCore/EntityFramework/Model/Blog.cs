namespace EntityFramework.Model
{
    public class Blog
    {
        public Blog(string name)
        {
            Name = name;
        }
        public int ID { get; private set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; } = new();
    }
}
