using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Repository.Models;
using OrderManagement.UI.ViewModel;
using System.Linq;

namespace OrderManagement.UI.Razor.Pages
{
    public class ShoppingCartPageModel : PageModel
    {
        private readonly IProductRepository _productRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartViewModel ShoppingCartViewModel { get; set; }
        public ShoppingCartPageModel(IProductRepository productRepository, ShoppingCart shoppingCart)
        {
            _productRepository = productRepository;
            _shoppingCart = shoppingCart;
        }
        public void OnGet()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            ShoppingCartViewModel = new()
            {
                ShoppingCart = _shoppingCart,
                ShappingCartTotal = _shoppingCart.GetShoppingCartTotal(),
            };
        }
        public RedirectToActionResult OnGetClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("OnGet");
        }
        public RedirectToActionResult OnGetAddToShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.GetProductById(productId);
            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("OnGet");
        }
        public RedirectToActionResult OnGetReduceQuantiyFromShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.ReduceQuantityFromCart(selectedProduct);
            }
            return RedirectToAction("OnGet");
        }
        public RedirectToActionResult OnGetRemoveFromShoppingCart(int productId)
        {
            var selectedProduct = _productRepository.GetAllProducts().FirstOrDefault(p => p.ProductId == productId);

            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("OnGet");
        }
    }
}
