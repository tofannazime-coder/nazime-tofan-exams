using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_GymMembers.Models;

namespace MVC_GymMembers.Controllers;

public class HomeController : Controller
{
    private readonly GymMembersDbContext _context;
    // veritabanı bağlantısını Controller'a aldık.

    public HomeController(GymMembersDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var members = await _context.Members.ToListAsync();
        // Members tablosundaki üyeleri çekiyor.

        return View(members);
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