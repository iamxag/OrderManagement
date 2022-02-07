using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Domain.Models;
using OrderManagement.Repository.Models;

namespace OrderManagement.UI.Razor.Pages
{
    public class ProductDetailsModel : PageModel
    {
        public IProductRepository ProductRepository { get; }
        public Product Product { get; set; }
        public ProductDetailsModel(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }
        public void OnGet(int id)
        {
            Product = ProductRepository.GetProductById(id);
        }
    }
}
