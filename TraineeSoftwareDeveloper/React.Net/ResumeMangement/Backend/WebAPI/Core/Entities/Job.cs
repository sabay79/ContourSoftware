using WebAPI.Core.Enums;

namespace WebAPI.Core.Entities
{
    public class Job : BaseEntity
    {
        public string Title { get; set; } = String.Empty;

        public JobLevel Level { get; set; }

        public long CompanyId { get; set; }
        public Company Company { get; set; }

        public ICollection<Candidate> Candidates { get; set; }

        public Job()
        {
            Candidates = new List<Candidate>();
        }
    }
}
