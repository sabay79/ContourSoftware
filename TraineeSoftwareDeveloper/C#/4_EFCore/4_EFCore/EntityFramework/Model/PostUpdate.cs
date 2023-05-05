using System.Net;

namespace EntityFramework.Model
{
    public class PostUpdate
    {
        public PostUpdate(IPAddress postedFrom, DateTime updatedOn)
        {
            PostedFrom = postedFrom;
            UpdatedOn = updatedOn;
        }
        public IPAddress PostedFrom { get; private set; }
        public string? UpdatedBy { get; init; }
        public DateTime UpdatedOn { get; private set; }
        public List<Commit> Commits { get; } = new();
    }
}