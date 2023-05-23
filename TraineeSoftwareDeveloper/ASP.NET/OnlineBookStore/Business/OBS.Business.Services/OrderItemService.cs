using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Business.Models;
using OBS.Business.Services;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class OrderItemService : Service<OrderItemModel, OrderItem>, IOrderItemService
    {
        public OrderItemService(IUnitOfWork<OrderItem> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        { }
    }
}