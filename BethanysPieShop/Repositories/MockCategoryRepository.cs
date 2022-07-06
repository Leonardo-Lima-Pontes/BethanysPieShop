using BethanysPieShop.Models;
using BethanysPieShop.Repositories.Interfaces;

namespace BethanysPieShop.Repositories;

public class MockCategoryRepository : ICategoryRepository
{
    public IEnumerable<Category> AllCategories =>
        new List<Category>
        {
            new Category {CategoryId = 1, CategoryName = "Frit pies", Description = "All-fruity pies"},
            new Category {CategoryId = 2, CategoryName = "Cheese cakes", Description = "Cheesy all the way"},
            new Category {CategoryId = 3, CategoryName = "Seasonal pies", Description = "Get in the mood of seasonal pies"},
            new Category {CategoryId = 4, CategoryName = "Salty pies", Description = "All salt pies whe have for you"},
            new Category {CategoryId = 5, CategoryName = "Sweet pies", Description = "All sweet pies whe have for you"}
        };
}