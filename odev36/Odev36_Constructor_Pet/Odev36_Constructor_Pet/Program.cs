using Odev36_Constructor_Pet.Models;

namespace Odev36_Constructor_Pet;

public class Program
{
    static void Main(string[] args)
    {
        Pet pet1 = new Pet("Boncuk", "Emine Kaya");
        Pet pet2 = new Pet("Pamuk", "Emirhan Can", "Kedi", 5);

        Pet[] pets = { pet1, pet2 };

        Console.WriteLine("➕ EVCİL HAYVAN LİSTE➕");

        foreach (Pet pet in pets)
        {
            Console.WriteLine($"Hayvan Ad : {pet.Name}");
            Console.WriteLine($"Sahip Ad Soyad : {pet.OwnerName}");
            Console.WriteLine($"Tür        : {pet.Type}");
            Console.WriteLine($"Yaş        : {pet.Age}");
            Console.WriteLine(new string('+', 30));
        }
    }
}