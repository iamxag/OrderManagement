using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository.Models;
using System.Linq;

namespace OrderManagement.UI.Razor.VIewComponents
{
    public class ContextMenuViewComponent : ViewComponent
    {
        private readonly ICategoryRepository categoryRepository;

        public ContextMenuViewComponent(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            return View(categoryRepository.GetAllCategories().OrderBy(c => c.CategoryName).ToList());
        }
    }
}
