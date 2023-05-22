using OBS.Data.Interfaces;

namespace OBS.Data.Services
{
    public class UnitOfWork<TEntity> : IUnitOfWork<TEntity>, IDisposable where TEntity : class
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IRepository<TEntity> _repository;
        //public IAuthorRepository Authors { get; }
        //public IPublisherRepository Publishers { get; }
        //public IBookRepository Books { get; }
        //public ICustomerRepository Customers { get; }
        //public IOrderRepository Orders { get; }
        //public IOrderItemRepository OrderItems { get; }

        public UnitOfWork(BookStoreDbContext dbContext, IRepository<TEntity> repository)
        {
            _dbContext = dbContext;
            _repository = repository;
            //Authors = authorRepository;
            //Publishers = publisherRepository;
            //Books = bookRepository;
            //Customers = customerRepository;
            //Orders = orderRepository;
            //OrderItems = orderItemRepository;
        }

        public IRepository<TEntity> Repository => _repository;

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
