using Microsoft.AspNetCore.Mvc;
using ToDoApp.WebAPI.Data;
using ToDoApp.WebAPI.Model;

namespace ToDoApp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly NoteBusinessServices _service;

        public NoteController(NoteBusinessServices service)
        {
            _service = service;
        }

        // GET: api/Note
        [HttpGet]
        public ActionResult<IEnumerable<Note>> GetNotes()
        {
            var notes = _service.GetAll();

            if (notes == null)
            {
                return NotFound();
            }

            return Ok(notes);
        }

        // GET: api/Note/5
        [HttpGet("{id}")]
        public ActionResult<Note> GetNote(int id)
        {
            var note = _service.Get(id);

            if (note == null)
            {
                return NotFound();
            }

            return Ok(note);
        }

        // POST: api/Note
        [HttpPost]
        public ActionResult<Note> PostNote(Note note)
        {
            _service.AddOrUpdate(note);
            return CreatedAtAction("GetNote", new Note { Id = note.Id }, note);
        }

        // PUT: api/Note/5
        [HttpPut("{id}")]
        public IActionResult PutNote(int id, Note note)
        {
            if (id != note.Id)
            {
                return BadRequest();
            }

            _service.AddOrUpdate(note);

            return CreatedAtAction("GetNote", new Note { Id = note.Id }, note);
        }

        // DELETE: api/Note/5
        [HttpDelete("{id}")]
        public IActionResult DeleteNote(int id)
        {
            var note = _service.Get(id);
            if (note == null)
            {
                return NotFound();
            }

            _service.Delete(note);   // https://stackoverflow.com/questions/12886559/cannot-implicitly-convert-type-from-task

            return Ok(_service.Get(id));
        }
    }
}
