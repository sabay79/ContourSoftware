using Microsoft.EntityFrameworkCore;
using ToDoApp.WebAPI.Data;

namespace ToDoApp.WebAPI.Model
{
    public class NoteBusinessServices
    {
        private readonly ToDoDbContext _dbContext;

        public NoteBusinessServices(ToDoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Note> GetAll() => _dbContext.Notes.ToList();

        public Note Get(int id) => _dbContext.Notes.Find(id);

        /// <summary>
        /// Entity states and SaveChanges
        /// https://learn.microsoft.com/en-us/ef/ef6/saving/change-tracking/entity-state?redirectedfrom=MSDN
        /// </summary>
        /// <param name="note"></param>
        public void AddOrUpdate(Note note)
        {
            _dbContext.Entry(note).State = note.Id == 0
                                            ? EntityState.Added
                                            : EntityState.Modified;
            Save();
        }

        public void Delete(Note note)
        {
            _dbContext.Notes.Remove(note);
            Save();
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}
