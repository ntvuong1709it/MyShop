using MyShop.Data.Entities;
using MyShop.Service.Models;

namespace MyShop.Service.Interfaces
{
    public interface ICategoryService
    {
        void Add(CategoryAddModel category);
    }
}