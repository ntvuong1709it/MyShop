using AutoMapper;
using MyShop.Data.Entities;
using MyShop.Repository.Interfaces;
using MyShop.Service.Interfaces;
using MyShop.Service.Models;

namespace MyShop.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Add(NewProductModel model)
        {
            var product = Mapper.Map<Product>(model);

            _productRepository.Add(product);
        }
    }
}