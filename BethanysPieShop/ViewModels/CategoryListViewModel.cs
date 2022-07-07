using BethanysPieShop.Models;

namespace BethanysPieShop.ViewModels;

public class CategoryListViewModel
{
    public CategoryListViewModel(string title, IEnumerable<Category> categories)
    {
        Title = title;
        Categories = categories;
    }

    public string Title { get; set; }
    public IEnumerable<Category> Categories { get; set; }
}