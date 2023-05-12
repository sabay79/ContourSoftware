using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Pages.Courses
{
    public class CreateModel : DepartmentNamePageModel
    {
        private readonly ContosoUniversityContext _context;

        public CreateModel(ContosoUniversityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateDepartmentsDropDownList(_context);
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyCourse = new Course();

            if (await TryUpdateModelAsync<Course>(emptyCourse, "course", // Prefix for form value.
                s => s.CourseID,
                s => s.DepartmentID,
                s => s.Title,
                s => s.Credits)
               )
            {
                _context.Courses.Add(emptyCourse);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            // Select DepartmentID if TryUpdateModelAsync fails.
            PopulateDepartmentsDropDownList(_context, emptyCourse.DepartmentID);
            return Page();
        }
        /*The preceding code:
            - Derives from DepartmentNamePageModel.
            - Uses TryUpdateModelAsync to prevent overposting.
            - Removes ViewData["DepartmentID"]. The DepartmentNameSL SelectList is a strongly typed model and will be used by the Razor page. Strongly typed models are preferred over weakly typed. 
        */
    }
}
