using System.Collections.Generic;

namespace OrderManagement.UI.Models
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductOfTheWeek();
        Product GetProductById(int id);
    }
}
