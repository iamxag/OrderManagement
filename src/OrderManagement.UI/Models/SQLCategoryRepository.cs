using System.Collections.Generic;
using System.Linq;

namespace OrderManagement.UI.Models
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;
        public SQLCategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Category> GetAllCategories()
        {

            return _appDbContext.Categories.ToList();
        }
    }
}
