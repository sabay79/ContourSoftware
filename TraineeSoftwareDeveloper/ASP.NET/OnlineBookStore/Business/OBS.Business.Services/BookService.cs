using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Business.Models;
using OBS.Business.Services;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class BookService : Service<BookModel, Book>, IBookService
    {
        public BookService(IUnitOfWork<Book> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        { }
    }
}