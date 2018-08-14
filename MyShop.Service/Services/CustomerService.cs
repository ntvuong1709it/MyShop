using System.Threading.Tasks;
using MyShop.Data.Entities;
using MyShop.Repository.Interfaces;
using MyShop.Service.Interfaces;

namespace MyShop.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void AddCustomer(Customer customer, string createdBy)
        {
            _customerRepository.Add(customer);
            _customerRepository.SaveChanges();
        }
    }
}