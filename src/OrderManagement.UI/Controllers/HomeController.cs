using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository.Models;

namespace OrderManagement.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(_productRepository.GetProductOfTheWeek());
        }
    }
}
