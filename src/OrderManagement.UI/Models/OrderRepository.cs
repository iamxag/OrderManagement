using System;
using System.Collections.Generic;

namespace OrderManagement.UI.Models
{
    public class OrderRepository : IOrderRepository
    {
        public readonly AppDbContext _appDbContext;
        public readonly ShoppingCart _shoppingCart;
        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
        }
        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;
            List<ShoppingCartItem> shoppingCartItems = _shoppingCart.GetShoppingCartItems();
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();
            order.OrderDetails = new List<OrderDetail>();
            foreach(ShoppingCartItem shoppingCartItem in shoppingCartItems)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Quantity = shoppingCartItem.Quantity,
                    ProductId = shoppingCartItem.Product.ProductId,
                    Price = shoppingCartItem.Product.Price
                };
                order.OrderDetails.Add(orderDetail);
            }
            _appDbContext.Orders.Add(order);
            _appDbContext.SaveChanges();
        }
    }
}
