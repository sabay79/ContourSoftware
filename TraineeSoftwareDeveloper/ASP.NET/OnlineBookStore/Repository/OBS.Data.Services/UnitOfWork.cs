using OBS.Data.Interfaces;

namespace OBS.Data.Services
{
    public class UnitOfWork : IDisposable
    {
        private readonly BookStoreDbContext _dbContext;

        public IAuthorRepository Authors { get; }
        public IPublisherRepository Publishers { get; }
        public IBookRepository Books { get; }
        public ICustomerRepository Customers { get; }
        public IOrderRepository Orders { get; }
        public IOrderItemRepository OrderItems { get; }

        public UnitOfWork(BookStoreDbContext dbContext,
                          IAuthorRepository authorRepository,
                          IPublisherRepository publisherRepository,
                          IBookRepository bookRepository,
                          ICustomerRepository customerRepository,
                          IOrderRepository orderRepository,
                          IOrderItemRepository orderItemRepository)
        {
            _dbContext = dbContext;
            Authors = authorRepository;
            Publishers = publisherRepository;
            Books = bookRepository;
            Customers = customerRepository;
            Orders = orderRepository;
            OrderItems = orderItemRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
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
