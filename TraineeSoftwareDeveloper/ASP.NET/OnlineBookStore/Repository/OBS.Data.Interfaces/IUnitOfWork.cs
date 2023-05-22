namespace OBS.Data.Interfaces
{
    public interface IUnitOfWork<TEntity> : IDisposable where TEntity : class
    {
        IRepository<TEntity> Repository { get; }
        //IAuthorRepository Authors { get; }
        //IPublisherRepository Publishers { get; }
        //IBookRepository Books { get; }
        //ICustomerRepository Customers { get; }
        //IOrderRepository Orders { get; }
        //IOrderItemRepository OrderItems { get; }

        void Save();

    }
}
