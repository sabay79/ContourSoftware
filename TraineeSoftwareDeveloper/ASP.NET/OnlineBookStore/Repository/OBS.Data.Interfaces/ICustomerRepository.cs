using OBS.Data.Models;

namespace OBS.Data.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
        Customer GetByID(int id);
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(int id);
        void Save();
    }
}