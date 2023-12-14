using WebAPI.Core.Enums;

namespace WebAPI.Core.DTOs.Job
{
    public class JobGetDTO
    {
        public long ID { get; set; }

        public string Title { get; set; } = String.Empty;

        public JobLevel Level { get; set; }

        public long CompanyId { get; set; }

        public string CompanyName { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
