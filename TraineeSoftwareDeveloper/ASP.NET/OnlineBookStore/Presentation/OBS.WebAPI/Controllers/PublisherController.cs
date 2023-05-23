using Microsoft.AspNetCore.Mvc;
using OBS.Business.Interfaces;
using OBS.Business.Models;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherService _publisherService;
        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        // GET : API/Authors
        [HttpGet]
        public ActionResult<IEnumerable<PublisherModel>> GetAll()
        {
            var publishers = _publisherService.GetAll();
            return Ok(publishers);
        }

        // GET : API/Author{id}
        [HttpGet("{id}")]
        public ActionResult<PublisherModel> Get(int id)
        {
            var publisher = _publisherService.GetByID(id);
            return Ok(publisher);
        }

        // POST : API/Author
        [HttpPost]
        public ActionResult<PublisherModel> Add([FromBody] PublisherModel publisher)
        {
            _publisherService.Add(publisher);
            return CreatedAtAction(nameof(Get), new { id = publisher.ID }, publisher);
        }

        [HttpPut]
        public ActionResult<PublisherModel> Update([FromBody] PublisherModel publisher)
        {
            _publisherService.Update(publisher);
            return Ok(publisher);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _publisherService.Delete(id);
            return Ok(_publisherService.GetByID(id));
        }
    }
}
