using System.Collections.Generic;

namespace OrderManagement.UI.Models
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
    }
}
