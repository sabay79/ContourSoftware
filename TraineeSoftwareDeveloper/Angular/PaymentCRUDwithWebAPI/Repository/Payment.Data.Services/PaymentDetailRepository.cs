using Microsoft.EntityFrameworkCore;
using Payment.Data.Interfaces;
using Payment.Data.Models;

namespace Payment.Data.Services
{
    public class PaymentDetailRepository : IPaymentDetailRepository
    {
        private readonly PaymentDetailContext _dbContext;
        private readonly DbSet<PaymentDetail> _dbSet;

        public PaymentDetailRepository(PaymentDetailContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<PaymentDetail>();
        }
        public IEnumerable<PaymentDetail> GetAll() => _dbSet.ToList();

        public PaymentDetail GetById(int id) => _dbSet.Find(id);

        public void Add(PaymentDetail paymentDetail)
        {
            _dbSet.Add(paymentDetail);
            Save();
        }

        public void Update(PaymentDetail paymentDetail)
        {
            _dbSet.Update(paymentDetail);
            Save();
        }

        public void Delete(PaymentDetail paymentDetail)
        {
            _dbSet.Remove(paymentDetail);
            Save();
        }

        private void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}