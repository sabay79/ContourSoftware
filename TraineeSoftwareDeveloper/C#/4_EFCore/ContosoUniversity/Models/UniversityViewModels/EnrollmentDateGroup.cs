using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models.UniversityViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
        public int StudentCount { get; set; }
    }
}
