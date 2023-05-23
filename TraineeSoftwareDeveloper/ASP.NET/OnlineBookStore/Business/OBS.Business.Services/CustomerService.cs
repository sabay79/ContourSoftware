using AutoMapper;
using OBS.Business.Interfaces;
using OBS.Business.Models;
using OBS.Business.Services;
using OBS.Data.Interfaces;
using OBS.Data.Models;

namespace OBS.Data.Services
{
    public class CustomerService : Service<CustomerModel, Customer>, ICustomerService
    {
        public CustomerService(IUnitOfWork<Customer> unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        { }
    }
}