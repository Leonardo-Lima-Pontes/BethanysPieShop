using BethanysPieShop.Models;

namespace BethanysPieShop.Repositories.Interfaces;

public interface IOrderRepository
{
    void CreateOrder(Order order);
}