using BethanysPieShop.Models;
using BethanysPieShop.Repositories.Interfaces;

namespace BethanysPieShop.Repositories;

public class CategoryRepository : ICategoryRepository
{
    public IEnumerable<Category> AllCategories { get; }
}