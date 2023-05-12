using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages.Instructors
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversityContext _context;

        public IndexModel(ContosoUniversityContext context)
        {
            _context = context;
        }

        public InstructorIndexData InstructorData { get; set; }
        public int InstructorID { get; set; }
        public int CourseID { get; set; }

        public async Task OnGetAsync(int? id, int? courseID)
        {
            InstructorData = new InstructorIndexData();

            InstructorData.Instructors = await _context.Instructors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.Courses)
                    .ThenInclude(c => c.Department)
                .OrderBy(i => i.Name)
                .ToListAsync();

            if (id != null)
            {
                InstructorID = id.Value;
                var instructor = InstructorData.Instructors
                    .Where(i => i.ID == InstructorID).Single();

                InstructorData.Courses = instructor.Courses;
            }

            if (courseID is not null)
            {
                CourseID = courseID.Value;
                var Enrollments = await _context.Enrollments
                    .Where(c => c.CourseID == CourseID)
                    .Include(i => i.Student)
                    .ToListAsync();

                InstructorData.Enrollments = Enrollments;
            }
        }
    }
}
