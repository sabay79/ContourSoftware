using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OBS.Business.Interfaces;
using OBS.Business.Models;

namespace OBS.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        // GET : API/Authors
        [HttpGet]
        public ActionResult<IEnumerable<AuthorModel>> GetAll()
        {
            var authors = _authorService.GetAll();
            //var authors = _authorService.GetAuthorBooks();
            return Ok(authors);
        }

        // GET : API/Author{id}
        [HttpGet("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult<AuthorModel> Get(int id)
        {
            var author = _authorService.GetByID(id);
            return Ok(author);
        }

        // POST : API/Author
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult<AuthorModel> Add([FromBody] AuthorModel author)
        {
            _authorService.Add(author);
            return CreatedAtAction(nameof(Get), new { id = author.ID }, author);
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public ActionResult<AuthorModel> Update([FromBody] AuthorModel author)
        {
            _authorService.Update(author);
            return Ok(author);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            _authorService.Delete(id);
            return Ok(_authorService.GetByID(id));
        }
    }
}
