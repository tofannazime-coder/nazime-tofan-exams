using System;
using System.Drawing;
using Odev15_Car.Models;
namespace Odev15_Car;

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>
        {
            new Car
            {
                Brand= "BMW",
                Model="F30",
                Year=2019,
                PlateNumber="34 BTL 554",
                Color="Gri"
            },
             new Car
            {
                Brand="Honda",
                Model="Civic",
                Year=2020,
                PlateNumber="41 GHT 963",
                Color="Kırmızı"
            },
             new Car
            {
                Brand="Renault",
                Model="Clio",
                Year=2019,
                PlateNumber="63 PNK 878",
                Color="Beyaz"
            },
        };
        Console.WriteLine("Arabalar: ");
        Console.WriteLine("**********");
        foreach (var car in cars)
        {
            Console.WriteLine($"Marka: {car.Brand}");
            Console.WriteLine($"Model: {car.Model}");
            Console.WriteLine($"Yıl: {car.Year}");
            Console.WriteLine($"Plaka: {car.PlateNumber}");
            Console.WriteLine($"Renk: {car.Color}");
            Console.WriteLine();
        }
    }
}