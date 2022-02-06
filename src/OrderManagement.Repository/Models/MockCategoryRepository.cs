using OrderManagement.Domain.Models;
using System.Collections.Generic;

namespace OrderManagement.Repository.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public List<Category> Categories { get; set; }
        public MockCategoryRepository()
        {
            Categories = new List<Category>()
            {
                new Category{ CategoryId = 1, CategoryName = "Fruits And Vegetable", Description= "All Fruits"},
                new Category{ CategoryId = 2, CategoryName = "Break Fast And Instance Food", Description= "the Items with breakfast"},
                new Category{ CategoryId = 3, CategoryName = "Pet Care", Description= "the Items with breakfast"},
            };
        }
        public List<Category> GetAllCategories()
        {           
            return Categories;
        }
    }
}
