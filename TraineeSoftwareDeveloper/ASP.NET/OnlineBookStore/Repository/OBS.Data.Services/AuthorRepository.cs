using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(BookStoreDbContext dbContext) : base(dbContext)
        { }
    }
}