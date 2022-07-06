using BethanysPieShop.Models;

namespace BethanysPieShop.Repositories.Interfaces;

public interface ICategoryRepository
{
    IEnumerable<Category> AllCategories { get; }
}