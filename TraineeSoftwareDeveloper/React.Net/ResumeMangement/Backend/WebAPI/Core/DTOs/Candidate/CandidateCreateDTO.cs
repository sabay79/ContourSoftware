namespace WebAPI.Core.DTOs.Candidate
{
    public class CandidateCreateDTO
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string CoverLetter { get; set; } = string.Empty;

        public long JobId { get; set; }
    }
}
