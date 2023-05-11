using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength((100), MinimumLength = 3, ErrorMessage = "Name cannot be longer than 100 characters.")]
        public string Name { get; set; }
        // Required attribute makes the name properties required fields.

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        // DataType attribute specifies a data type that's more specific than the database intrinsic type.
        // ApplyFormatInEditMode setting specifies that the formatting should also be applied to the edit UI.

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
