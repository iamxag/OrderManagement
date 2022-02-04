using System.Collections.Generic;

namespace OrderManagement.UI.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public List<Category> categories { get; set; }
        public MockCategoryRepository()
        {
            categories = new List<Category>()
            {
                new Category{ CategoryId = 1, CategoryName = "Fruits And Vegetable", Description= "All Fruits"},
                new Category{ CategoryId = 2, CategoryName = "Break Fast And Instance Food", Description= "the Items with breakfast"},
                new Category{ CategoryId = 3, CategoryName = "Pet Care", Description= "the Items with breakfast"},
            };
        }
        public List<Category> GetAllCategories()
        {           
            return categories;
        }
    }
}
