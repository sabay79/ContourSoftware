using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Business.Models;
using OBS.Business.Services;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class OrderService : Service<OrderModel, Order>, IOrderService
    {
        public OrderService(IUnitOfWork<Order> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        { }
    }
}