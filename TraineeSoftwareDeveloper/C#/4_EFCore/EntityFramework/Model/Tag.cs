namespace EntityFramework.Model
{
    public class Tag
    {
        public Tag(int id, string text)
        {
            ID = id;
            Text = text;
        }
        public int ID { get; private set; }
        public string Text { get; set; }
        public List<Post> Posts { get; } = new();
    }
}