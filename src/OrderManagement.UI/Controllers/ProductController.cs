using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Domain.Models;
using OrderManagement.Repository.Models;
using System.Linq;

namespace OrderManagement.UI.Controllers
{
    public class ProductController : Controller
    {
        public IProductRepository ProductRepository { get; }
        public ProductController(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }

        public IActionResult Details(int id)
        {
            ViewBag.Title = "Detials";
            Product product =  ProductRepository.GetProductById(id);
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
                return View(ProductRepository.GetAllProducts());
            }
            else
            {
                return View(ProductRepository.GetAllProducts().Where(x => x.Category.CategoryName == categoryName).OrderBy(p => p.ProductId).ToList());
            }           
            
        }
    }
}
