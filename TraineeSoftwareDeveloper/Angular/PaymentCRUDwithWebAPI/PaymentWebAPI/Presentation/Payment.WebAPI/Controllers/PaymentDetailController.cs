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

        [HttpGet]
        public ActionResult<IEnumerable<PaymentDetailModel>> Get() => Ok(_paymentDetailService.GetAll());

        [HttpGet("{id}")]
        public ActionResult<PaymentDetailModel> Get(int id) => Ok(_paymentDetailService.GetById(id));

        [HttpPost]
        public ActionResult<PaymentDetailModel> Post([FromBody] PaymentDetailModel paymentDetailModel)
        {
            _paymentDetailService.Add(paymentDetailModel);
            return Ok(_paymentDetailService.GetAll());
        }

        [HttpPut("{id}")]
        public ActionResult<PaymentDetailModel> Put(int id, [FromBody] PaymentDetailModel paymentDetailModel)
        {
            if (id != paymentDetailModel.PaymentDetailID)
                return BadRequest();

            _paymentDetailService.Update(paymentDetailModel);
            return Ok(_paymentDetailService.GetAll());
        }

        [HttpPatch("{id}")]
        public ActionResult<PaymentDetailModel> Patch(int id, [FromBody] PaymentDetailModel paymentDetailModel)
        {
            if (id != paymentDetailModel.PaymentDetailID)
                return BadRequest();

            _paymentDetailService.Update(paymentDetailModel);
            return Ok(_paymentDetailService.GetAll());
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _paymentDetailService.Delete(id);
            return Ok(_paymentDetailService.GetAll());
        }
    }
}
