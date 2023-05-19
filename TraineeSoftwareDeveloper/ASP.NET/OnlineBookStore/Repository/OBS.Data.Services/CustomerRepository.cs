using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BookStoreDbContext dbContext) : base(dbContext)
        { }
    }
}