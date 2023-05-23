using AutoMapper;
using OBS.Business.Models;
using OBS.Data.Models;

namespace OBS.Business.Services
{
    public class BusinessEntityMapping : Profile
    {
        public BusinessEntityMapping()
        {
            CreateMap<AuthorModel, Author>().ReverseMap();
            CreateMap<PublisherModel, Publisher>().ReverseMap();
            CreateMap<BookModel, Book>().ReverseMap();
            CreateMap<CustomerModel, Customer>().ReverseMap();
            CreateMap<OrderModel, Order>().ReverseMap();
            CreateMap<OrderItemModel, OrderItem>().ReverseMap();
        }
    }
}
