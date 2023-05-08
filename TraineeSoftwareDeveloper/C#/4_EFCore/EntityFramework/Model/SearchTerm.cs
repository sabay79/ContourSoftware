namespace EntityFramework.Model
{
    public class SearchTerm
    {
        public SearchTerm(string term, int count)
        {
            Term = term;
            Count = count;
        }
        public string Term { get; private set; }
        public int Count { get; private set; }
    }
}