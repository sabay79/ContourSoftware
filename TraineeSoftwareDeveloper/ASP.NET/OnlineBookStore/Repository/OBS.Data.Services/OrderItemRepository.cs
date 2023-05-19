using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class OrderItemRepository : GenericRepository<OrderItem>, IOrderItemRepository
    { }
}