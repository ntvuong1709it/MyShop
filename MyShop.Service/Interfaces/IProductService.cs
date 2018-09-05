using MyShop.Data.Entities;
using MyShop.Service.Models;

namespace MyShop.Service.Interfaces
{
    public interface IProductService
    {
        void Add(NewProductModel model);
    }
}