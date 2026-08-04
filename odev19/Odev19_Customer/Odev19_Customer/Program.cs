using System.Runtime.Serialization;
using Odev19_Customer.Models;

namespace Odev19_Customer;

class Program
{
    static void Main(string[] args)
    {
        Customer customer1 = new Customer("Hasan Yanıkdağ", "Kartal Mah. No:45 Bayrampaşa/İstanbul", new DateTime(2000, 12, 22));
        Customer customer2 = new Customer("Banu Çelik", "Altıntepsi Mah. No:108 Esenler/İstanbul", new DateTime(1999, 10, 22));

        Console.WriteLine("⟪ Müşteri Bilgi ⟫");

        Console.WriteLine($"Ad Soyad: {customer1.Name} | Adres: {customer1.Address} | Doğum Tarih: {customer1.BirthDate}");
        Console.WriteLine($"Ad Soyad: {customer2.Name} | Adres: {customer2.Address} | Doğum Tarih: {customer2.BirthDate}");

    }
}