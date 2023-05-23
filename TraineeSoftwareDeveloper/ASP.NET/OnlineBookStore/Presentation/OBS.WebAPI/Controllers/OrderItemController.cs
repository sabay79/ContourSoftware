using Microsoft.AspNetCore.Mvc;
using OBS.Business.Interfaces;
using OBS.Business.Models;

namespace OBS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly IOrderItemService _orderItemService;
        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        // GET : API/Authors
        [HttpGet]
        public ActionResult<IEnumerable<OrderItemModel>> GetAll()
        {
            var orderItems = _orderItemService.GetAll();
            return Ok(orderItems);
        }

        // GET : API/Author{id}
        [HttpGet("{id}")]
        public ActionResult<OrderItemModel> Get(int id)
        {
            var orderItem = _orderItemService.GetByID(id);
            return Ok(orderItem);
        }

        // POST : API/Author
        [HttpPost]
        public ActionResult<OrderItemModel> Add([FromBody] OrderItemModel orderItem)
        {
            _orderItemService.Add(orderItem);
            return CreatedAtAction(nameof(Get), new { id = orderItem.ID }, orderItem);
        }

        [HttpPut]
        public ActionResult<OrderItemModel> Update([FromBody] OrderItemModel orderItem)
        {
            _orderItemService.Update(orderItem);
            return Ok(orderItem);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _orderItemService.Delete(id);
            return Ok(_orderItemService.GetByID(id));
        }
    }
}
