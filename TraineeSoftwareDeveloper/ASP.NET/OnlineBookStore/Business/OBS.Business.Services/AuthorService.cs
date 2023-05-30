using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Business.Models;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Business.Services
{
    public class AuthorService : Service<AuthorModel, Author>, IAuthorService
    {
        //private readonly IUnitOfWork<Author> _unitOfWork;
        //private readonly IMapper _mapper;
        public AuthorService(IUnitOfWork<Author> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            //_unitOfWork = unitOfWork;
            //_mapper = mapper;
        }
        //public IEnumerable<Author> GetAuthorBooks()
        //{
        //    return _unitOfWork.Authors.GetAuthorBooks().ToList();
        //}
    }
}
