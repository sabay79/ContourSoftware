namespace OBS.Data.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAuthorRepository AuthorRepository { get; }
        IPublisherRepository PublisherRepository { get; }
        IBookRepository BookRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }
        IOrderItemRepository OrderItemRepository { get; }

        int Save();

    }
}
