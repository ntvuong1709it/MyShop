using MyShop.Data.Entities;
using MyShop.Data.Interfaces;
using MyShop.Repository.Interfaces;

namespace MyShop.Repository.Repositories
{
    public class WalletRepository : GenericRepository<Wallet>, IWalletRepository
    {
        public WalletRepository(IApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}