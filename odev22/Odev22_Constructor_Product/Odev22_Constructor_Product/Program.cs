using System;
namespace Odev22_Product.Models;

public class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Akıllı Telefon");
        product1.Id = 4574;
        product1.Price = 28999.99m;

        Product product2 = new Product("Bluetooth Kulaklık");
        product2.Id = 9385;
        product2.Price = 3499.99m;

        Product product3 = new Product("Akıllı Saat");
        product3.Id = 3958;
        product3.Price = 7999.99m;

        Console.WriteLine($"Ürün Ad: {product1.Name} - Fiyat: {product1.Price}");
        Console.WriteLine($"Ürün Ad: {product2.Name} - Fiyat: {product2.Price}");
        Console.WriteLine($"Ürün Ad: {product3.Name} - Fiyat: {product3.Price}");
    }
}