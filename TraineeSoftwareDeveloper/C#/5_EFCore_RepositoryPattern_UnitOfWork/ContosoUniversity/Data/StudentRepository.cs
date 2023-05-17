using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private UniversityDbContext _context;
        public StudentRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetStudents() => _context.Students.ToList();
        public Student GetStudentByID(int id) => _context.Students.Find(id);
        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }
        public void DeleteStudent(int studentID)
        {
            var student = GetStudentByID(studentID);
            _context.Students.Remove(student);
        }
        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }
        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

    }
}
