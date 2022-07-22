using BethanysPieShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Components;

public class CategoryMenu : ViewComponent
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryMenu(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke() => 
        View(_categoryRepository.AllCategories.OrderBy(category => category.CategoryName));
}