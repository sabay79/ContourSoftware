using Microsoft.EntityFrameworkCore;
using OBS.Data.Interfaces;

namespace OBS.Data.Services
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();
        public IEnumerable<TEntity> GetAllInclude(string include) => _dbSet.Include(include).ToList();
        // pass name in string and then split and then use here
        public TEntity GetByID(int id) => _dbSet.Find(id);
        public void Add(TEntity entity) => _dbSet.Add(entity);
        public void Update(TEntity entity) => _dbSet.Update(entity);
        public void Delete(TEntity entity) => _dbSet.Remove(entity);
    }
}
