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
            try
            {
                _dbSet.Add(paymentDetail);
                Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(PaymentDetail paymentDetail)
        {
            try
            {
                _dbSet.Update(paymentDetail);
                Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(PaymentDetail paymentDetail)
        {
            try
            {
                _dbSet.Remove(paymentDetail);
                Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Save()
        {
            try
            {
                _dbContext.SaveChanges();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}