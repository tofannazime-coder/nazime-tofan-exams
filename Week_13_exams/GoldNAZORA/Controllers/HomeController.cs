
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GoldNAZORA.Models;

namespace GoldNAZORA.Controllers
{

    public class HomeController : Controller // ASP.NET Core MVC'nin Controller sınıfından miras alır.
    {
        public IActionResult Index() //Ana Sayfa
        {
            return View();
        }

        public IActionResult Collection() // Koleksiyon
        {
            return View();
        }

        public IActionResult About() // Hakkımızda
        {
            return View();
        }

        public IActionResult Privacy() // Gizlilik Sayfası
        {
            return View();
        }

        [ResponseCache( // Metoda eklenen özelliktir.
            Duration = 0, // Yanıtın önbellekte tutulması için süreyi sıfır olarak belirtir.
            Location = ResponseCacheLocation.None, // Yanıtın istemci veya paylaşılan önbelleklerde tutulmamasını belirtir.
            NoStore = true)] //Yanıtın önbelleğe kaydedilmemesini ister.
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }

}