namespace ContosoUniversity.Models.UniversityViewModels
{
    public class AssignedCourseData
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public bool Assigned { get; set; }
    }
    // AssignedCourseData class contains data to create the checkboxes for courses assigned to an instructor.
}
