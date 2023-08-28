using AutoMapper;
using Payment.Business.Models;
using Payment.Data.Models;

namespace Payment.Business.Services
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<PaymentDetailModel, PaymentDetail>().ReverseMap();
        }
    }
}
