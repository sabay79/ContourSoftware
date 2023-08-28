using Microsoft.AspNetCore.Mvc;
using Payment.Business.Interfaces;
using Payment.Business.Models;

namespace Payment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentDetailController : ControllerBase
    {
        private readonly IPaymentDetailService _paymentDetailService;

        public PaymentDetailController(IPaymentDetailService paymentDetailService)
        {
            _paymentDetailService = paymentDetailService;
        }

        // GET
        [HttpGet]
        public ActionResult<IEnumerable<PaymentDetailModel>> Get() => Ok(_paymentDetailService.GetAll());

        // GET By ID
        [HttpGet("{id}")]
        public ActionResult<PaymentDetailModel> Get(int id) => Ok(_paymentDetailService.GetById(id));

        // POST
        [HttpPost]
        public ActionResult<PaymentDetailModel> Post([FromBody] PaymentDetailModel paymentDetailModel)
        {
            _paymentDetailService.Add(paymentDetailModel);
            return CreatedAtAction(nameof(Get), new { id = paymentDetailModel.PaymentDetailID }, paymentDetailModel);
        }

        // PUT
        [HttpPut("{id}")]
        public ActionResult<PaymentDetailModel> Put([FromBody] PaymentDetailModel paymentDetailModel)
        {
            _paymentDetailService.Update(paymentDetailModel);
            return Ok(paymentDetailModel);
        }

        // DELETE 
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //var paymentDetail = _paymentDetailService.GetById(id);
            _paymentDetailService.Delete(id);
            return Ok(_paymentDetailService.GetById(id));
        }
    }
}
