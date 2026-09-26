using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_TravelGuide.Models;

namespace MVC_TravelGuide.Controllers;

public class HomeController : Controller
{
    private readonly TravelGuideDbContext _context;

    public HomeController(TravelGuideDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var places = _context.Places.ToList();

        return View(places);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}