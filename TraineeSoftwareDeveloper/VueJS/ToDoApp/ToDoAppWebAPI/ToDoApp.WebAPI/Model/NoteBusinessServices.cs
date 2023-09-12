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

        public async Task<IEnumerable<Note>> GetAll() => await _dbContext.Notes.ToListAsync();

        public async Task<Note> Get(Guid id) => await _dbContext.Notes.FindAsync(id);

        //public async void Add(Note note)
        //{
        //    //await _dbContext.Notes.AddAsync(note);
        //    _dbContext.Entry(note).State = EntityState.Added;
        //    await _dbContext.SaveChangesAsync();
        //}

        //public async void Update(Note note)
        //{
        //    //_dbContext.Notes.Update(note);
        //    _dbContext.Entry(note).State = EntityState.Modified;
        //    await _dbContext.SaveChangesAsync();
        //}

        /// <summary>
        /// Entity states and SaveChanges
        /// https://learn.microsoft.com/en-us/ef/ef6/saving/change-tracking/entity-state?redirectedfrom=MSDN
        /// </summary>
        /// <param name="note"></param>
        public async void AddOrUpdate(Note note)
        {
            _dbContext.Entry(note).State = note.Id == Guid.Parse("bd0c16cd-e1ef-4694-8429-06870c4af0b9")
                                                    ? EntityState.Added
                                                    : EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async void Delete(Note note)
        {
            _dbContext.Notes.Remove(note);
            await _dbContext.SaveChangesAsync();
        }
    }
}
