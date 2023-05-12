using ContosoUniversity.Data;
using ContosoUniversity.Models;
using ContosoUniversity.Models.UniversityViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoUniversity.Pages.Instructors
{
    public class InstructorCoursesPageModel : PageModel
    {
        public List<AssignedCourseData> AssignedCourseDataList;
        public void PopulateAssignedCourseData(ContosoUniversityContext _context, Instructor instructor)
        {
            var allCourses = _context.Courses;
            var instructorCourses = new HashSet<int>(instructor
                                                    .Courses
                                                    .Select(c => c.CourseID)
                                                    );
            AssignedCourseDataList = new List<AssignedCourseData>();
            foreach (var course in allCourses)
            {
                AssignedCourseDataList.Add(new AssignedCourseData
                {
                    CourseID = course.CourseID,
                    Title = course.Title,
                    Assigned = instructorCourses.Contains(course.CourseID)
                });
            }
        }
    }
    // PopulateAssignedCourseData reads all Course entities to populate AssignedCourseDataList.
    // For each course, the code sets the CourseID, title, and whether or not the instructor is assigned to the course.
    // A HashSet is used for efficient lookups.
}
