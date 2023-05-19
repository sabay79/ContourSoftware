using Microsoft.EntityFrameworkCore;
using OBS.Data.Interfaces;

namespace OBS.Data.Services
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;
        public GenericRepository()
        {
            _dbContext = new BookStoreDbContext();
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll() => _dbSet.ToList();
        public TEntity GetByID(int id) => _dbSet.Find(id);
        public void Add(TEntity entity) => _dbSet.Add(entity);
        public void Update(TEntity entity) => _dbSet.Update(entity);
        public void Delete(int id)
        {
            var entity = GetByID(id);
            _dbSet.Remove(entity);
        }
        public void Save() => _dbContext.SaveChanges();

    }
}
