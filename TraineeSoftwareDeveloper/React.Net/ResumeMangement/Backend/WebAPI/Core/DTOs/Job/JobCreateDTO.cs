using WebAPI.Core.Enums;

namespace WebAPI.Core.DTOs.Job
{
    public class JobCreateDTO
    {
        public string Title { get; set; } = String.Empty;

        public JobLevel Level { get; set; }

        public long CompanyId { get; set; }
    }
}
