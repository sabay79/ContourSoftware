using Microsoft.AspNetCore.Mvc;
using OBS.Business.Interfaces;
using OBS.Business.Models;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET : API/Authors
        [HttpGet]
        public ActionResult<IEnumerable<BookModel>> GetAll()
        {
            var books = _bookService.GetAll();
            return Ok(books);
        }

        // GET : API/Author{id}
        [HttpGet("{id}")]
        public ActionResult<BookModel> Get(int id)
        {
            var book = _bookService.GetByID(id);
            return Ok(book);
        }

        // POST : API/Author
        [HttpPost]
        public ActionResult<BookModel> Add([FromBody] BookModel book)
        {
            _bookService.Add(book);
            return CreatedAtAction(nameof(Get), new { id = book.ID }, book);
        }

        [HttpPut]
        public ActionResult<BookModel> Update([FromBody] BookModel book)
        {
            _bookService.Update(book);
            return Ok(book);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return Ok(_bookService.GetByID(id));
        }
    }
}
