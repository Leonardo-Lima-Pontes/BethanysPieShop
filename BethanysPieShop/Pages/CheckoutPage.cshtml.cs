using BethanysPieShop.Models;
using BethanysPieShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BethanysPieShop.Pages;

public class CheckoutPage : PageModel
{
    [BindProperty]
    public Order Order { get; set; }

    private readonly IOrderRepository _orderRepository;
    private readonly IShoppingCart _shoppingCart;

    public CheckoutPage(IOrderRepository orderRepository, IShoppingCart shoppingCart)
    {
        _orderRepository = orderRepository;
        _shoppingCart = shoppingCart;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }
        
        var items = _shoppingCart.GetShoppingCartItems();
        _shoppingCart.ShoppingCartItems = items;

        if (_shoppingCart.ShoppingCartItems.Count == 0)
        {
            ModelState.AddModelError("", "You cart is empty, please add some pies to continue");
            
        }

        if(ModelState.IsValid)
        {
            _orderRepository.CreateOrder(Order );
            _shoppingCart.ClearCart();
            return RedirectToAction("CheckoutCompletePage");
        }
        
        return Page();
    }
}