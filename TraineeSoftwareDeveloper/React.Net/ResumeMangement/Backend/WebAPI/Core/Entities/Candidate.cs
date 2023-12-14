namespace WebAPI.Core.Entities
{
    public class Candidate : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string CoverLetter { get; set; } = string.Empty;

        public string ResumeUrl { get; set; } = string.Empty;

        public long JobId { get; set; }
        public Job Job { get; set; }
    }
}
