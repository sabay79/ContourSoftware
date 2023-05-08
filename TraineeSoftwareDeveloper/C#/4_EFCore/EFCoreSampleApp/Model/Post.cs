namespace EFCoreSampleApp.Model
{
    public class Post
    {
        public int PostID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogID { get; set; }
        public Blog Blog { get; set; }
    }
}