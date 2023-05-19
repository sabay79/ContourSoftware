using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(BookStoreDbContext dbContext) : base(dbContext)
        { }
    }
}