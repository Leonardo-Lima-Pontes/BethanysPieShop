using BethanysPieShop.Models;
using BethanysPieShop.Repositories.Interfaces;

namespace BethanysPieShop.Repositories;

public class PieRepository : IPieRepository
{
    public IEnumerable<Pie> AllPies { get; }
    public IEnumerable<Pie> PiesOfTheWeek { get; }
    
    public Pie? GetPieById(int pieId)
    {
        throw new NotImplementedException();
    }
}