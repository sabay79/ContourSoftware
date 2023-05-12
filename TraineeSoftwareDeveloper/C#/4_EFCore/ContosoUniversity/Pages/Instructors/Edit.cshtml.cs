using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Pages.Instructors
{
    public class EditModel : InstructorCoursesPageModel
    {
        private readonly ContosoUniversityContext _context;

        public EditModel(ContosoUniversityContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Instructor Instructor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Instructor = await _context.Instructors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.Courses)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Instructor == null)
            {
                return NotFound();
            }

            PopulateAssignedCourseData(_context, Instructor);
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync(int? id, string[] selectedCourses)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructorToUpdate = await _context.Instructors
                .Include(i => i.OfficeAssignment)
                .Include(i => i.Courses)
                .FirstOrDefaultAsync(s => s.ID == id);

            if (instructorToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Instructor>(instructorToUpdate, "Instructor",
                i => i.Name,
                i => i.HireDate,
                instructorToUpdate => instructorToUpdate.OfficeAssignment))
            {
                if (String.IsNullOrWhiteSpace(instructorToUpdate.OfficeAssignment?.Location))
                {
                    instructorToUpdate.OfficeAssignment = null;
                }

                UpdateInstructorCourses(selectedCourses, instructorToUpdate);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }
            UpdateInstructorCourses(selectedCourses, instructorToUpdate);
            PopulateAssignedCourseData(_context, instructorToUpdate);
            return Page();
        }

        public void UpdateInstructorCourses(string[] selectedCourses, Instructor instructorToUpdate)
        {
            if (selectedCourses == null)
            {
                instructorToUpdate.Courses = new List<Course>();
                return;
            }

            var selectedCoursesHS = new HashSet<string>(selectedCourses);
            var instructorCourses = new HashSet<int>(instructorToUpdate
                                                        .Courses
                                                        .Select(c => c.CourseID)
                                                    );
            foreach (var course in _context.Courses)
            {
                if (selectedCoursesHS.Contains(course.CourseID.ToString()))
                {
                    if (!instructorCourses.Contains(course.CourseID))
                    {
                        instructorToUpdate.Courses.Add(course);
                    }
                }
                else
                {
                    if (instructorCourses.Contains(course.CourseID))
                    {
                        var courseToRemove = instructorToUpdate
                                            .Courses
                                            .Single(c => c.CourseID == course.CourseID);
                        instructorToUpdate.Courses.Remove(courseToRemove);
                    }
                }
            }
        }
    }
}
/*
 * The preceding code:
    - Gets the current Instructor entity from the database using eager loading for the OfficeAssignment and Courses navigation properties.
    - Updates the retrieved Instructor entity with values from the model binder. TryUpdateModelAsync prevents overposting.
    - If the office location is blank, sets Instructor.OfficeAssignment to null. When Instructor.OfficeAssignment is null, the related row in the OfficeAssignment table is deleted.
    - Calls PopulateAssignedCourseData in OnGetAsync to provide information for the checkboxes using the AssignedCourseData view model class.
    - Calls UpdateInstructorCourses in OnPostAsync to apply information from the checkboxes to the Instructor entity being edited.
    - Calls PopulateAssignedCourseData and UpdateInstructorCourses in OnPostAsync if TryUpdateModelAsync fails. These method calls restore the assigned course data entered on the page when it is redisplayed with an error message.
      
      https://learn.microsoft.com/en-us/aspnet/core/data/ef-rp/update-related-data?view=aspnetcore-7.0#update-the-instructor-edit-page-model
 */