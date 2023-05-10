using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoUniversity.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly ContosoUniversity.Data.ContosoUniversityContext _context;

        public CreateModel(ContosoUniversity.Data.ContosoUniversityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }


        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD - IMPORTANT //
        public async Task<IActionResult> OnPostAsync()
        {
            var emptyStudent = new Student();

            if (await TryUpdateModelAsync<Student>(
                emptyStudent,
                "student",  // Prefix for form value.
                s => s.Name,
                s => s.EnrollmentDate))
            {
                _context.Students.Add(emptyStudent);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }

            return Page();

            // TryUpdateModelAsync : https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/crud?view=aspnetcore-7.0#tryupdatemodelasync
        }
    }
}
