namespace EFCoreSampleApp.Model
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string URL { get; set; }

        public List<Post> Posts { get; } = new();
    }
}
