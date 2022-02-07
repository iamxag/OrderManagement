using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OrderManagement.Domain.Models;
using OrderManagement.Repository.Models;

namespace OrderManagement.UI.Razor.Pages
{
    public class CheckoutModel : PageModel
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;
        public CheckoutModel(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        [BindProperty]
        public Order Order { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
                ModelState.AddModelError("", "No Items");
            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(Order);
                _shoppingCart.ClearCart();
                return RedirectToPage("CompleteCheckOut");
            }
            return RedirectToAction("OnGet");
        }
    }
}
