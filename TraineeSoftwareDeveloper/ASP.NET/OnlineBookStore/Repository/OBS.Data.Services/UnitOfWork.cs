using OBS.Data.Interfaces;

namespace OBS.Data.Services
{
    public class UnitOfWork<TEntity> : IUnitOfWork<TEntity>, IDisposable where TEntity : class
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IRepository<TEntity> _repository;
        //public IAuthorRepository authors;
        //public IPublisherRepository Publishers { get; }
        //public IBookRepository Books { get; }
        //public ICustomerRepository Customers { get; }
        //public IOrderRepository Orders { get; }
        //public IOrderItemRepository OrderItems { get; }

        public UnitOfWork(BookStoreDbContext dbContext, IRepository<TEntity> repository)
        {
            _dbContext = dbContext;
            _repository = repository;
            //authors = authorRepository;
            //Publishers = publisherRepository;
            //Books = bookRepository;
            //Customers = customerRepository;
            //Orders = orderRepository;
            //OrderItems = orderItemRepository;
        }

        public IRepository<TEntity> Repository => _repository;
        //public IAuthorRepository Authors => authors;

        #region DatabaseTransactionApproach
        public void BeginTransaction()
        {
            _dbContext.Database.BeginTransaction();
        }
        public void CommitTransaction()
        {
            _dbContext.Database.CommitTransaction();
        }
        public void RollbackTransaction()
        {
            _dbContext.Database.RollbackTransaction();
        }
        #endregion

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
