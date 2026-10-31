
using Microsoft.AspNetCore.Mvc;

namespace GoldNAZORA.Controllers
{
    public class CartController : Controller
    {
        // Sepet sayfasını açar.
        public IActionResult Index()
        {
            return View();
        }

        // Teslimat bilgileri sayfasını açar.
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        // Sipariş formundan gelen bilgileri kontrol eder.
        [HttpPost]
        public IActionResult ConfirmOrder(
            string FullName,
            string Phone,
            string City,
            string District,
            string Address)
        {
            // Zorunlu bilgiler boş bırakılmış mı kontrol eder.
            if (string.IsNullOrWhiteSpace(FullName) ||   // "||" Koşullardan en az biri doğruysa çalışır.
               string.IsNullOrWhiteSpace(Phone) ||
               string.IsNullOrWhiteSpace(City) ||
               string.IsNullOrWhiteSpace(District) ||
               string.IsNullOrWhiteSpace(Address)) // Bu kod telefon,il,ilçe ve adres alanalrın boş bırakılıp bırakılmadığını kontrol ediyor.
            {
                return View("Checkout");
            }

            // Sipariş bilgilerini başarı sayfasına aktarır.
            ViewBag.FullName = FullName;
            ViewBag.Phone = Phone;
            ViewBag.Address = $"{District}, {City} - {Address}";

            return View("OrderSuccess");
        }
    }
}