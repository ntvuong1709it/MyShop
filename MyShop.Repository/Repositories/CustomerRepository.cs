using MyShop.Data.Entities;
using MyShop.Data.Interfaces;
using MyShop.Repository.Interfaces;

namespace MyShop.Repository.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        public CustomerRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}