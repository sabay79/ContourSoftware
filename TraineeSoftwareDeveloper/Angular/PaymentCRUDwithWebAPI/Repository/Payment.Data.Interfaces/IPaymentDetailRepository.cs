using Payment.Data.Models;

namespace Payment.Data.Interfaces
{
    public interface IPaymentDetailRepository
    {
        IEnumerable<PaymentDetail> GetAll();
        PaymentDetail GetById(int id);
        void Add(PaymentDetail paymentDetail);
        void Update(PaymentDetail paymentDetail);
        void Delete(PaymentDetail paymentDetail);
    }
}
