using Microsoft.AspNetCore.Mvc;
using Payment.Business.Models;
using Payment.Data.Interfaces;
using Payment.Data.Models;

namespace Payment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly IPaymentDetailRepository _paymentDetailService;

        public PaymentDetailController(IPaymentDetailRepository paymentDetailService)
        {
            _paymentDetailService = paymentDetailService;
        }

        // GET: api/<PaymentDetailController>
        [HttpGet]
        public ActionResult<IEnumerable<PaymentDetailModel>> Get() => Ok(_paymentDetailService.GetAll());

        // GET api/<PaymentDetailController>/5
        [HttpGet("{id}")]
        public ActionResult<PaymentDetailModel> Get(int id) => Ok(_paymentDetailService.GetById(id));

        // POST api/<PaymentDetailController>
        [HttpPost]
        public ActionResult<PaymentDetailModel> Post([FromBody] PaymentDetail paymentDetailModel)
        {
            _paymentDetailService.Add(paymentDetailModel);
            return CreatedAtAction(nameof(Get), new { id = paymentDetailModel.PaymentDetailID }, paymentDetailModel);
        }

        // PUT api/<PaymentDetailController>/5
        [HttpPut("{id}")]
        public ActionResult<PaymentDetailModel> Put([FromBody] PaymentDetail paymentDetailModel)
        {
            _paymentDetailService.Update(paymentDetailModel);
            return Ok(paymentDetailModel);
        }

        // DELETE api/<PaymentDetailController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var paymentDetail = _paymentDetailService.GetById(id);
            _paymentDetailService.Delete(paymentDetail);
            return Ok(_paymentDetailService.GetById(id));
        }
    }
}
