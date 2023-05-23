using Microsoft.AspNetCore.Mvc;
using OBS.Business.Interfaces;
using OBS.Business.Models;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET : API/Authors
        [HttpGet]
        public ActionResult<IEnumerable<CustomerModel>> GetAll()
        {
            var customers = _customerService.GetAll();
            return Ok(customers);
        }

        // GET : API/Author{id}
        [HttpGet("{id}")]
        public ActionResult<CustomerModel> Get(int id)
        {
            var customer = _customerService.GetByID(id);
            return Ok(customer);
        }

        // POST : API/Author
        [HttpPost]
        public ActionResult<CustomerModel> Add([FromBody] CustomerModel customer)
        {
            _customerService.Add(customer);
            return CreatedAtAction(nameof(Get), new { id = customer.ID }, customer);
        }

        [HttpPut]
        public ActionResult<CustomerModel> Update([FromBody] CustomerModel customer)
        {
            _customerService.Update(customer);
            return Ok(customer);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _customerService.Delete(id);
            return Ok(_customerService.GetByID(id));
        }
    }
}
