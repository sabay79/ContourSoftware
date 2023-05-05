namespace EntityFramework.Model
{
    public class PostMetadata
    {
        public PostMetadata(int views)
        {
            Views = views;
        }
        public int Views { get; set; }
        public List<SearchTerm> TopSearches { get; } = new();
        public List<Visits> TopGeographies { get; } = new();
        public List<PostUpdate> Updates { get; } = new();
    }
}