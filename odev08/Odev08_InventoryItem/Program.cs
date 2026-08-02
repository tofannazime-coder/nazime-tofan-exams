using System;

namespace Odev08_InventoryManagement.Models
{
    public class Program
    {
       static void Main(string[] args)
        {

            InventoryItem item = new InventoryItem("Ürün A", 50);
            Console.WriteLine($"Başlangıç Stok: {item.Quantity}");

            item.IncreaseStock(20);
            Console.WriteLine($"Stok artırıldı. Yeni Stok: {item.Quantity}");

            bool decreaseResult1 = item.DecreaseStock(30);
            Console.WriteLine(decreaseResult1 ? $"Stok azaltıldı. Yeni Stok: {item.Quantity}" : "Stok azaltma başarısız oldu.");

            bool decreaseResult2 = item.DecreaseStock(60);
            Console.WriteLine(decreaseResult2 ? $"Stok azaltıldı. Yeni Stok: {item.Quantity}" : "Stok azaltma başarısız oldu.");

        }
    }
}