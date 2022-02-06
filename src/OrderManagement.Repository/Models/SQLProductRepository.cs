using Microsoft.EntityFrameworkCore;
using OrderManagement.Data.Models;
using OrderManagement.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.Repository.Models
{
    public class SQLProductRepository : IProductRepository
    {
        private readonly AppDbContext _appDbContext;
        public SQLProductRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Product> GetAllProducts()
        {
            return _appDbContext.Products.Include(c => c.Category).ToList();
        }

        public Product GetProductById(int id)
        {
            return _appDbContext.Products.Include(c => c.Category).Where(x => x.ProductId == id).FirstOrDefault();
        }

        public List<Product> GetProductOfTheWeek()
        {
            return _appDbContext.Products.Include(c => c.Category).Where(x => x.IsProductOfTheWeek == true).ToList();
        }
    }
}
