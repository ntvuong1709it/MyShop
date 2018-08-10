using Microsoft.AspNetCore.Mvc;
using MyShop.Service.Interfaces;
using MyShop.Service.Models;

namespace MyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public IActionResult Add(CategoryAddModel model)
        {
            _categoryService.Add(model);
            return Ok();
        }
    }
}