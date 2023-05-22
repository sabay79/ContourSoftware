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
        }
    }
}
