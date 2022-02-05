using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.UI.Models
{
    public class MockProductRepository : IProductRepository
    {
        readonly List<Product> _products;
        public MockProductRepository()
        {
            _products = new List<Product>()
            {
                new Product() { ProductId = 1, Name = "Colgate Strong Teeth", ImageUrl="/Images/Colgate.jpg", Price = 235, ShortDescription="500 Grams", LongDescription="Tooth sensitivity is something that affects a number of people. It is often caused by eating or drinking something hot, cold, sweet or acidic. Under normal conditions, the underlying dentin of the tooth (the layer that immediately surrounds the nerve) is covered by the enamel in the tooth crown, and the gums that surround the tooth. Over time, the enamel covering can get thinner, thus providing less protection. The gums can also recede over time, exposing the underlying root surface dentin." },
                new Product() { ProductId = 2, Name = "Maggi Masala Noodles", ImageUrl="/Images/Maggi.jpg", Price = 138, ShortDescription="Maggi Masala Noodles - Pack of 12", LongDescription="Maggi 2-Minute Masala Noodles is an instant noodles brand manufactured by Nestle. Made with the choicest quality spices. Each portion (70g) provides 15% of your daily iron requirement. Ready in 2 minutes, perfect for a hangout or house party.", IsProductOfTheWeek = true}
            };
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public Product GetProductById(int id)
        {
            return _products.Where(x => x.ProductId == id).FirstOrDefault();
        }


        public List<Product> GetProductOfTheWeek()
        {
            return _products.Where(x => x.IsProductOfTheWeek == true).ToList();
        }
    }
}
