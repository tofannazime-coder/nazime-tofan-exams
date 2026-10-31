
using Microsoft.AspNetCore.Mvc;

namespace GoldNAZORA.Controllers
{
    public class AccountController : Controller // ASP.NET Core MVC'nin Controller sınıfından miras alır.
    {
        public IActionResult Login() // Parantezlerin boş olması parametre almadığını gösteriyor.
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(password)) // Alanların boş olup olmadığını kontrol ediyor.
            {
                ViewBag.Message = "Lütfen e-posta ve şifrenizi girin.";
                return View(); // Başarı mesajını view a aktarır.
            }

            ViewBag.Message = "Giriş başarılı! Ailemize Hoş geldiniz.";
            return View(); //Giriş sayfasını yeniden gösteriyor.
        }
    }
}
