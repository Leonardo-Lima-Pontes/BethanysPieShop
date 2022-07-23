using System.IO.Compression;
using BethanysPieShop.Models;
using BethanysPieShop.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers.Api;

[Route("api/[controller]")]
[ApiController]
public class SearchController : ControllerBase
{
    private readonly IPieRepository _pieRepository;

    public SearchController(IPieRepository pieRepository)
    {
        _pieRepository = pieRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var pies = _pieRepository.AllPies;
        return Ok(pies);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var pie = _pieRepository.GetPieWithCategoryById(id);
        if (pie == null)
            return NotFound("This pie is not here");

        return Ok(pie);
    }

    [HttpPost]
    public IActionResult GetByName([FromBody] string searchQuery)
    {
        var pies = _pieRepository.SearchPies(searchQuery);
        if (!pies.Any())
            return NotFound("There are no pies with this name here, please try again");

        return new JsonResult(pies);
    }
}