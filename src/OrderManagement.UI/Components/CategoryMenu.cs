using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository.Models;
using System.Linq;

namespace OrderManagement.UI.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(_categoryRepository.GetAllCategories().OrderBy(c => c.CategoryName).ToList());
        }
    }
}
