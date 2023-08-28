using AutoMapper;
using Payment.Business.Models;
using Payment.Data.Models;

namespace Payment.Business.Services
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            // Provide all Mapper Configuration
            MapperConfiguration config = new(cfg => cfg.CreateMap<PaymentDetailModel, PaymentDetail>().ReverseMap());

            // Create Instance of Mapper
            Mapper mapper = new(config);

            //  Return that Instance
            return mapper;

        }
    }
}
