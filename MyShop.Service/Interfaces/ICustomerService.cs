using System.Threading.Tasks;
using MyShop.Data.Entities;

namespace MyShop.Service.Interfaces
{
    public interface ICustomerService
    {
        void AddCustomer(Customer customer, string createdBy);
    }
}