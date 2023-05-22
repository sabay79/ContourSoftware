using Microsoft.AspNetCore.Mvc;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IUnitOfWork<Author> _unitOfWork;
        public AuthorController(IUnitOfWork<Author> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET : API/Authors
        [HttpGet]
        public ActionResult<IEnumerable<Author>> GetAll()
        {
            var authors = _unitOfWork.Repository.GetAll();
            return Ok(authors);
        }

        // GET : API/Author{id}
        [HttpGet("{id}")]
        public ActionResult<Author> Get(int id)
        {
            var author = _unitOfWork.Repository.GetByID(id);
            return Ok(author);
        }

        // POST : API/Author
        [HttpPost]
        public ActionResult<Author> Add([FromBody] Author author)
        {
            _unitOfWork.Repository.Add(author);
            _unitOfWork.Save();

            return CreatedAtAction(nameof(Get), new { id = author.ID }, author);
        }

        [HttpPut("{id}")]
        public ActionResult<Author> Update(int id, [FromBody] Author author)
        {
            var authorToUpdate = _unitOfWork.Repository.GetByID(id);
            if (authorToUpdate == null)
            {
                return NotFound();
            }

            authorToUpdate.Name = author.Name;
            authorToUpdate.Gender = author.Gender;
            authorToUpdate.Email = author.Email;
            authorToUpdate.Books = author.Books;

            _unitOfWork.Repository.Update(author);
            _unitOfWork.Save();

            return Ok(authorToUpdate);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var authorToDelete = _unitOfWork.Repository.GetByID(id);
            if (authorToDelete == null)
            {
                return NotFound(id);
            }

            _unitOfWork.Repository.Delete(authorToDelete);
            _unitOfWork.Save();

            return Ok(authorToDelete);
        }
    }
}
