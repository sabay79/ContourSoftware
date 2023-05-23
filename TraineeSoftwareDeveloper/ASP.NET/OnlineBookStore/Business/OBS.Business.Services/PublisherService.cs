using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Business.Models;
using OBS.Business.Services;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class PublisherService : Service<PublisherModel, Publisher>, IPublisherService
    {
        public PublisherService(IUnitOfWork<Publisher> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        { }
    }
}