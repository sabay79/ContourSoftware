using ContosoUniversity.Data;
using ContosoUniversity.Models.UniversityViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages
{
    public class AboutModel : PageModel
    {
        private readonly ContosoUniversityContext _context;
        public AboutModel(ContosoUniversityContext context)
        {
            _context = context;
        }

        public IList<EnrollmentDateGroup> Students { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<EnrollmentDateGroup> data = from student in _context.Students
                                                   group student by student.EnrollmentDate into dateGroup
                                                   select new EnrollmentDateGroup()
                                                   {
                                                       EnrollmentDate = dateGroup.Key,
                                                       StudentCount = dateGroup.Count()
                                                   };
            Students = await data.AsNoTracking().ToListAsync();

            // The LINQ statement groups the student entities by enrollment date, calculates the number of entities in each group, and stores the results in a collection of EnrollmentDateGroup view model objects.
        }
    }
}
