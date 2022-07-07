using BethanysPieShop.Database;
using BethanysPieShop.Models;
using BethanysPieShop.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Repositories;

public class PieRepository : IPieRepository
{
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

    public PieRepository(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }
    
    public IEnumerable<Pie> AllPies => _bethanysPieShopDbContext.Pies.Include(pie => pie.Category);
    public IEnumerable<Pie> PiesOfTheWeek => _bethanysPieShopDbContext.Pies.Include(pie => pie.Category).Where(pie => pie.IsPieOfTheWeek);

    public Pie? GetPieById(int pieId) => _bethanysPieShopDbContext.Pies.FirstOrDefault(pie => pie.PieId == pieId);
}