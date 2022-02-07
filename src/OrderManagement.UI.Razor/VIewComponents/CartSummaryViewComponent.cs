using Microsoft.AspNetCore.Mvc;
using OrderManagement.Repository.Models;

namespace OrderManagement.UI.Razor.VIewComponents
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public CartSummaryViewComponent(ShoppingCart shoppingCart)
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
