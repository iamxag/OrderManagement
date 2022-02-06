using Microsoft.AspNetCore.Mvc;
using OrderManagement.UI.Models;

namespace OrderManagement.UI.Components
{
    public class CartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public CartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;            
            return View(_shoppingCart.ShoppingCartItems.Count);
        }
    }
}
