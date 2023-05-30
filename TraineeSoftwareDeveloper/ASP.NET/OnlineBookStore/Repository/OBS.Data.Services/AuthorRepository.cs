using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        //private readonly BookStoreDbContext _dbContext;
        public AuthorRepository(BookStoreDbContext dbContext) : base(dbContext)
        {
            //_dbContext = dbContext;
        }
        //public IEnumerable<Author> GetAuthorBooks()
        //{
        //    return _dbContext.Authors
        //        .Include(a => a.AuthorBooks)
        //        .ThenInclude(ab => ab.Book)
        //        .ToList();
        //}
    }
}