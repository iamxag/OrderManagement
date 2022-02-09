using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrderManagement.Domain.Models;
using OrderManagement.Repository.Models;
using System.Collections.Generic;

namespace OrderManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductRepository ProductRepository { get; }
        public ProductController(IProductRepository productRepository)
        {
            ProductRepository = productRepository;
        }
        [HttpGet("GetProductsList")]
        public IActionResult GetProductsList()
        {
            List<Product> Products = ProductRepository.GetAllProducts();
            List<ProductView> productView = MapProductLitsToProductViewList(Products);
            string result = JsonConvert.SerializeObject(productView);
            return new ObjectResult(result);
        }

        [HttpGet("GETProductByID")]
        public IActionResult GETProductByID(int Id, string category)
        {
            Product product = ProductRepository.GetProductById(Id);
            ProductView productView = MapProductToProductView(product);
            string result = JsonConvert.SerializeObject(productView);
            return new ObjectResult(result);
        }
        
        private static ProductView MapProductToProductView(Product product)
        {
            return new ProductView()
            {
                Name = product.Name,
                CategoryId = product.CategoryId,
                ImageThumbnailUrl = product.ImageThumbnailUrl,
                ImageUrl = product.ImageUrl,
                InStock = product.InStock,
                IsProductOfTheWeek = product.IsProductOfTheWeek,
                LongDescription = product.LongDescription,
                Price = product.Price,
                ProductId = product.ProductId,
                ShortDescription = product.ShortDescription
            };
        }

        [HttpGet("GetProductOfTheWeek")]
        public IActionResult GetProductOfTheWeek()
        {
            List<Product> Products = ProductRepository.GetProductOfTheWeek();
            List<ProductView> productView = MapProductLitsToProductViewList(Products);
            string result = JsonConvert.SerializeObject(productView);
            return new ObjectResult(result);
        }

        private static List<ProductView> MapProductLitsToProductViewList(List<Product> Products)
        {
            List<ProductView> productView = new List<ProductView>();
            foreach (Product product in Products)
            {
                productView.Add(MapProductToProductView(product));
            }
            return productView;
        }
    }
}
