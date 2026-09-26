using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_VetClinic.Models;

namespace MVC_VetClinic.Controllers;

public class HomeController : Controller
{
    private readonly VetClinicDbContext _context; 
    // Controller'a veritabanına ulaşma aracını verdik

   // Constructor ile bağladık
    public HomeController(VetClinicDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var pets = await _context.Pets.ToListAsync();

        return View(pets);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}