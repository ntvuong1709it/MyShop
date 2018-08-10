using AutoMapper;
using MyShop.Data.Entities;
using MyShop.Repository.Interfaces;
using MyShop.Service.Interfaces;
using MyShop.Service.Models;

namespace MyShop.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Add(CategoryAddModel model)
        {
            var category = Mapper.Map<Category>(model);

            _categoryRepository.Add(category);
            _categoryRepository.SaveChanges();
        }
    }
}