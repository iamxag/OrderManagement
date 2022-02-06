using OrderManagement.Domain.Models;
using System.Collections.Generic;

namespace OrderManagement.Repository.Models
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategories();
    }
}
