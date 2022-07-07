using BethanysPieShop.Database;
using BethanysPieShop.Models;
using BethanysPieShop.Repositories.Interfaces;

namespace BethanysPieShop.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

    public CategoryRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }

    public IEnumerable<Category> AllCategories => _bethanysPieShopDbContext.Categories.OrderBy(category => category.CategoryName);
}