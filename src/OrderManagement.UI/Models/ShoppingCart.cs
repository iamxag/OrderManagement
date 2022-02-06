using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.UI.Models
{
    public class ShoppingCart
    {
        private readonly AppDbContext _context;
        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        private ShoppingCart(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return _context.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId).Include(s => s.Product).ToList();
        }

        public decimal GetShoppingCartTotal()
        {
            return _context.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Select(c => c.Product.Price * c.Quantity).Sum();
        }

        public void ClearCart()
        {
            List<ShoppingCartItem> cardItems = _context.ShoppingCartItems.Where(x => x.ShoppingCartId == ShoppingCartId).Include(s => s.Product).ToList();
            _context.ShoppingCartItems.RemoveRange(cardItems);
            _context.SaveChanges();
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId};
        }

        public void AddToCart(Product product, int quantity)
        {
            ShoppingCartItem shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(x => x.Product.ProductId == product.ProductId && x.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Quantity = quantity
                };
                _context.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _context.SaveChanges();
        }

        public void RemoveFromCart(Product product)
        {
            ShoppingCartItem shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(x => x.Product.ProductId == product.ProductId && x.ShoppingCartId == ShoppingCartId);
            if(shoppingCartItem != null)
                _context.ShoppingCartItems.Remove(shoppingCartItem);
            _context.SaveChanges();
        }

        public int ReduceQuantityFromCart(Product product)
        {
            ShoppingCartItem shoppingCartItem = _context.ShoppingCartItems.SingleOrDefault(x => x.Product.ProductId == product.ProductId && x.ShoppingCartId == ShoppingCartId);
            int localQuantity = 0;
            if(shoppingCartItem != null )
            {
                if(shoppingCartItem.Quantity > 1)
                {
                    localQuantity = --shoppingCartItem.Quantity;
                }
                    
                else
                    _context.ShoppingCartItems.Remove(shoppingCartItem);
            }
            _context.SaveChanges();
            return localQuantity;
        }

    }
}
