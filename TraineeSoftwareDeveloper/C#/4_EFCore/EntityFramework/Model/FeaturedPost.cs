namespace EntityFramework.Model
{
    public class FeaturedPost : Post
    {
        public FeaturedPost(string title, string content, DateTime publishedOn, string promoText)
            : base(title, content, publishedOn)
        {
            PromoText = promoText;
        }
        public string PromoText { get; set; }
    }
}
