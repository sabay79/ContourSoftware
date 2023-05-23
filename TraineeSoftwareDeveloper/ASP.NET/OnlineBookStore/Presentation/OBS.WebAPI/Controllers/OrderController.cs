using Microsoft.AspNetCore.Mvc;
using OBS.Business.Interfaces;
using OBS.Business.Models;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        // GET : API/Authors
        [HttpGet]
        public ActionResult<IEnumerable<OrderModel>> GetAll()
        {
            var orders = _orderService.GetAll();
            return Ok(orders);
        }

        // GET : API/Author{id}
        [HttpGet("{id}")]
        public ActionResult<OrderModel> Get(int id)
        {
            var order = _orderService.GetByID(id);
            return Ok(order);
        }

        // POST : API/Author
        [HttpPost]
        public ActionResult<OrderModel> Add([FromBody] OrderModel order)
        {
            _orderService.Add(order);
            return CreatedAtAction(nameof(Get), new { id = order.ID }, order);
        }

        [HttpPut]
        public ActionResult<OrderModel> Update([FromBody] OrderModel order)
        {
            _orderService.Update(order);
            return Ok(order);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _orderService.Delete(id);
            return Ok(_orderService.GetByID(id));
        }
    }
}
