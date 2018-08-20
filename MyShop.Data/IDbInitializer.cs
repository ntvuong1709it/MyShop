using System.Threading.Tasks;

namespace MyShop.Data
{
    public interface IDbInitializer
    {
        Task CreateUserRoles();
        void Initialize(ApplicationDbContext context);
    }
}