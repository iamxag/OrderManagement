using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.UI.Models;

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
        public ViewResult List()        
        {
            string Url = HttpContext.Request.GetEncodedUrl();
            Url = Url.Remove(Url.LastIndexOf("/"));
            Url = Url.Remove(Url.LastIndexOf("/"));
            ViewBag.Url = Url;
            ViewBag.Title = "ProductList";
            return View(_productRepository.GetAllProducts());
        }
    }
}
