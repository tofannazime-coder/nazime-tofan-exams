using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_CafeMenu.Models;

namespace MVC_CafeMenu.Controllers;

public class HomeController : Controller
{
    private readonly CafeMenuDbContext _context;

    public HomeController(CafeMenuDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var menuItems = _context.MenuItems.ToList();

        return View(menuItems);
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