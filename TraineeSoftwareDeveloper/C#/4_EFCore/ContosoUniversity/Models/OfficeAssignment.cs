using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        // [Key] attribute is used to identify a property as the primary key (PK) when the property name is something other than classnameID or ID

        [StringLength(50)]
        [Display(Name = "Office Lcation")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}