namespace ContosoUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Related to over-posting attacks 
        //public string Secret { get; set; }

        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
