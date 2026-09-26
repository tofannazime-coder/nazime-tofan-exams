using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_MovieArchive.Models;

namespace MVC_MovieArchive.Controllers;

public class HomeController : Controller
{
    private readonly MovieArchiveDbContext _context;

    public HomeController(MovieArchiveDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var movies = await _context.Movies.ToListAsync();

        return View(movies);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
        });
    }
}
