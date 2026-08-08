using Odev29_Constructor_Laptop.Models;

namespace Odev29_Constructor_Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("Dell", "Inspiron");
            laptop1.RamGb = 8;
            laptop1.StorageGb = 350;
            laptop1.Price = 21000;


            Laptop laptop2 = new Laptop("Lenovo", "ThinkPad", 18, 533);
            laptop2.Price = 43000;

            Laptop[] laptops = { laptop1, laptop2 };
            Console.WriteLine("➕ LAPTOP LİSTE ➕");

            foreach (Laptop laptop in laptops)
            {
                Console.WriteLine($"Marka    : {laptop.Brand}");
                Console.WriteLine($"Model    : {laptop.Model}");
                Console.WriteLine($"RAM      : {laptop.RamGb} GB");
                Console.WriteLine($"Depolama : {laptop.StorageGb} GB");
                Console.WriteLine($"Fiyat    : {laptop.Price} TL");
                Console.WriteLine(new string('+', 35));
            }

        }
    }
}