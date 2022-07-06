using BethanysPieShop.Models;

namespace BethanysPieShop.Repositories.Interfaces;

public interface IPieRepository
{
    IEnumerable<Pie> AllPies { get; }
    IEnumerable<Pie> PiesOfTheWeek { get; }
    Pie? GetPieById(int pieId);
}