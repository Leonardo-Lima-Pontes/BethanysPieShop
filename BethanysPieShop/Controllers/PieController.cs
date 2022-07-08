using BethanysPieShop.Repositories.Interfaces;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        
        public PieController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult List() => View(new PieListViewModel(_pieRepository.AllPies, "Cheese cakes"));

        public IActionResult Details(int id)
        {
            var pie = _pieRepository.GetPieById(id);
            if (pie == null)
                return NotFound();

            return View(pie);
        }
    }
}