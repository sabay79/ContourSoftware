using AutoMapper;
using Payment.Business.Interfaces;
using Payment.Business.Models;
using Payment.Data.Interfaces;
using Payment.Data.Models;

namespace Payment.Business.Services
{
    public class PaymentDetailService : IPaymentDetailService
    {
        private readonly IPaymentDetailRepository _paymentDetailRepository;
        private readonly IMapper _mapper;

        public PaymentDetailService(IPaymentDetailRepository paymentDetailRepository, IMapper mapper)
        {
            _paymentDetailRepository = paymentDetailRepository;
            _mapper = mapper;
        }

        public List<PaymentDetailModel> GetAll()
        {
            var paymentDetailList = _paymentDetailRepository.GetAll();
            var paymentDetailListModel = _mapper.Map<List<PaymentDetailModel>>(paymentDetailList);
            return paymentDetailListModel;
        }

        public PaymentDetailModel GetById(int id)
        {
            var paymentDetail = _paymentDetailRepository.GetById(id);
            var paymentDetailModel = _mapper.Map<PaymentDetailModel>(paymentDetail);
            return paymentDetailModel;
        }

        public void Add(PaymentDetailModel paymentDetailModel)
        {
            try
            {
                var paymentDetail = _mapper.Map<PaymentDetail>(paymentDetailModel);
                _paymentDetailRepository.Add(paymentDetail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(PaymentDetailModel paymentDetailModel)
        {
            try
            {
                var paymentDetail = _mapper.Map<PaymentDetail>(paymentDetailModel);
                _paymentDetailRepository.Update(paymentDetail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var paymentDetail = _paymentDetailRepository.GetById(id);
                if (paymentDetail != null)
                {
                    _paymentDetailRepository.Delete(paymentDetail);
                }
            }
            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
