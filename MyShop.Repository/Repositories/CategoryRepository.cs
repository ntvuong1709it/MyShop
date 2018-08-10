using MyShop.Data;
using MyShop.Data.Entities;
using MyShop.Data.Interfaces;
using MyShop.Repository.Interfaces;

namespace MyShop.Repository.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}