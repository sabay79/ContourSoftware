using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Business.Models;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Business.Services
{
    public class AuthorService : Service<AuthorModel, Author>, IAuthorService
    {
        public AuthorService(IUnitOfWork<Author> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        { }
    }
}
