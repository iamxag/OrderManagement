using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderManagement.API.Model;
using OrderManagement.Domain.Models;
using OrderManagement.Repository.Models;
using System.Collections.Generic;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(ICategoryRepository categoryRepository)
        {
            CategoryRepository = categoryRepository;
        }

        public ICategoryRepository CategoryRepository { get; }

        [HttpGet]
        public IActionResult GetAllCategories()
        {
            List<Category> categories = CategoryRepository.GetAllCategories();
            List<CategoryView> categoryViews = MapCategoryWithCategoryView(categories);
            string result = JsonConvert.SerializeObject(categoryViews);
            return new ObjectResult(result);
        }

        private static List<CategoryView> MapCategoryWithCategoryView(List<Category> categories)
        {
            List<CategoryView> categoryViews = new List<CategoryView>();
            foreach (Category category in categories)
            {
                categoryViews.Add(new CategoryView()
                {
                    CategoryId = category.CategoryId,
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                });
            }

            return categoryViews;
        }
    }
}
