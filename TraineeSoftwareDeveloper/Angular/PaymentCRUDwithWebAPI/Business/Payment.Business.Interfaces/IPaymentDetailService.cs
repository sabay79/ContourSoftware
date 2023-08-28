using Payment.Business.Models;

namespace Payment.Business.Interfaces
{
    public interface IPaymentDetailService
    {
        List<PaymentDetailModel> GetAll();
        PaymentDetailModel GetById(int id);
        void Add(PaymentDetailModel paymentDetailModel);
        void Update(PaymentDetailModel paymentDetailModel);
        void Delete(int id);
    }
}
