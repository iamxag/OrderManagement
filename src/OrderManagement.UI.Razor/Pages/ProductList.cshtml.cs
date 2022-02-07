using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Domain.Models;
using OrderManagement.Repository.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.UI.Razor.Pages
{
    public class ProductListModel : PageModel
    {
        
        public IProductRepository ProductRepository { get; }
        public List<Product> Products { get; set; }
        public ProductListModel(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }
        public string URL { get; set; }
        public void OnGet(string categoryName)
        {
            URL = HttpContext.Request.GetEncodedUrl();
            URL = URL.Remove(URL.LastIndexOf("/"));
            URL = URL.Remove(URL.LastIndexOf("/"));            
            if (string.IsNullOrEmpty(categoryName))
            {
                Products = ProductRepository.GetAllProducts();
            }
            else
            {
                Products = ProductRepository.GetAllProducts().Where(x => x.Category.CategoryName == categoryName).OrderBy(p => p.ProductId).ToList();
            }

        }
    }
}
