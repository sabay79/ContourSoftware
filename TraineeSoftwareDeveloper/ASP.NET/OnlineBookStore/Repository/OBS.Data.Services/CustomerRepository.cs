using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BookStoreDbContext _context;
        public CustomerRepository()
        {
            _context = new BookStoreDbContext();
        }
        public IEnumerable<Customer> GetAll() => _context.Customers.ToList();
        public Customer GetByID(int id) => _context.Customers.Find(id);
        public void Add(Customer customer) => _context.Customers.Add(customer);
        public void Update(Customer customer) => _context.Customers.Update(customer);
        public void Delete(int id)
        {
            var customer = GetByID(id);
            _context.Customers.Remove(customer);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}