using Odev31_Constructor_CoffeeOrder.Models;

namespace Odev31_Constructor_CoffeeOrder;

public class Program
{
    static void Main(string[] args)
    {
        CoffeeOrder coffeeOrder1 = new CoffeeOrder("Nazlı", "Ice Americano");
        coffeeOrder1.SugarCount = 2;

        CoffeeOrder coffeeOrder2 = new CoffeeOrder("Yusuf", "Ice Latte");
        coffeeOrder2.SugarCount = 0;

        CoffeeOrder coffeeOrder3 = new CoffeeOrder("Ercan", "Hot Mocha");
        coffeeOrder3.SugarCount = 1;

        CoffeeOrder[] coffeeOrders = { coffeeOrder1, coffeeOrder2, coffeeOrder3 };


        Console.WriteLine("➕ KAHVE SİPARİŞ LİSTE ➕");

        foreach (CoffeeOrder coffeeOrder in coffeeOrders)
        {
            Console.WriteLine($"Müşteri Ad : {coffeeOrder.CustomerName}");
            Console.WriteLine($"Kahve Türü  : {coffeeOrder.CoffeeType}");
            Console.WriteLine($"Kahve Boyu   : {coffeeOrder.Size}");
            Console.WriteLine($"Şeker Sayısı: {coffeeOrder.SugarCount}");
            Console.WriteLine(new string('-', 20));
        }
    }
}