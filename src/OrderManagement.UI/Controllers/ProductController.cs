using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.UI.Models;
using System.Linq;

namespace OrderManagement.UI.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepository _productRepository { get; }
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Details(int id)
        {
            ViewBag.Title = "Detials";
            Product product =  _productRepository.GetProductById(id);
            return View(product);
        }
        public ViewResult List(string categoryName)        
        {
            string Url = HttpContext.Request.GetEncodedUrl();
            Url = Url.Remove(Url.LastIndexOf("/"));
            Url = Url.Remove(Url.LastIndexOf("/"));
            ViewBag.Url = Url;
            ViewBag.Title = "ProductList";
            if (string.IsNullOrEmpty(categoryName))
            {
                return View(_productRepository.GetAllProducts());
            }
            else
            {
                return View(_productRepository.GetAllProducts().Where(x => x.Category.CategoryName == categoryName).OrderBy(p => p.ProductId).ToList());
            }           
            
        }
    }
}
