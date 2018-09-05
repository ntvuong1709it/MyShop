using System.Linq;
using MyShop.Data.Entities;
using MyShop.Data.Interfaces;
using MyShop.Repository.Interfaces;

namespace MyShop.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly IApplicationDbContext _dbContext;

        public ProductRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}