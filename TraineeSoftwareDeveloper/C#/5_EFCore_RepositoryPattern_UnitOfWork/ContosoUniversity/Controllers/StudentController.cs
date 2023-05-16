using ContosoUniversity.Data;
using ContosoUniversity.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace ContosoUniversity.Controllers
{
    public class StudentController : Controller
    {
        private readonly UniversityDbContext _context;

        public StudentController(UniversityDbContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            return _context.Student != null ?
                        View(await _context.Student.ToListAsync()) :
                        Problem("Entity set 'UniversityDbContext.Student'  is null.");
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student
                .Include(s => s.Enrollments)
                .ThenInclude(e => e.Course)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,LastName,FirstMidName,EnrollmentDate")] Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(student);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DataException dex)
            {
                Console.WriteLine(dex.Message);
                //ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(student);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,LastName,FirstMidName,EnrollmentDate")] Student student)
        {
            if (id != student.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id, bool? saveChangesError = false)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            if(saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Delete failed. Try again, and if the problem persists see your system administrator.";
            }

            var student = await _context.Student
                .FirstOrDefaultAsync(m => m.ID == id);
            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Student == null)
            {
                return Problem("Entity set 'UniversityDbContext.Student'  is null.");
            }

            try
            {
                var student = await _context.Student.FindAsync(id);

                if (student != null)
                {
                    _context.Student.Remove(student);
                }

                await _context.SaveChangesAsync();
            }
            catch (DataException dex) 
            {
                Console.WriteLine(dex.Message);
                return RedirectToAction("Delete", new { id, saveChangesError = true });
            }
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExists(int id)
        {
            return (_context.Student?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
