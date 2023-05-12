using ContosoUniversity.Data;
//using ContosoUniversity.Models;
using ContosoUniversity.Models.UniversityViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversityContext _context;

        public IndexModel(ContosoUniversityContext context)
        {
            _context = context;
        }

        // Loads Data with 'Select' Method //
        #region snippet_RevisedIndexMethod
        public IList<CourseViewModel> CourseVM { get; set; }
        public async Task OnGetAsync()
        {
            CourseVM = await _context.Courses
                    .Select(p => new CourseViewModel
                    {
                        CourseID = p.CourseID,
                        Title = p.Title,
                        Credits = p.Credits,
                        DepartmentName = p.Department.Name
                    }).ToListAsync();
        }
        #endregion

        // Loads Data with 'Include' Method //
        //public IList<Course> Courses { get; set; }

        //public async Task OnGetAsync()
        //{
        //    if (_context.Courses != null)
        //    {
        //        Courses = await _context.Courses
        //        .Include(c => c.Department)
        //        .AsNoTracking()
        //        .ToListAsync();
        //        /*
        //         * No-tracking queries are useful when the results are used in a read-only scenario. 
        //         * They're generally quicker to execute because there's no need to set up the change tracking information. 
        //         */
        //    }
        //}
    }
}
