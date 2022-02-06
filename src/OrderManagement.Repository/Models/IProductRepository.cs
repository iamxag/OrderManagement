using OrderManagement.Domain.Models;
using System.Collections.Generic;

namespace OrderManagement.Repository.Models
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        List<Product> GetProductOfTheWeek();
        Product GetProductById(int id);
    }
}
