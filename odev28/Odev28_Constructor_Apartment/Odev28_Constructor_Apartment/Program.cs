using System;
using Odev28_Constructor_Apartment.Models;

namespace Odev28_Constructor_Apartment
{
    class Program
    {
        static void Main(string[] args)
        {
            Apartment apartment1 = new Apartment(16, 6)
            {
                RentPrice = 28000.00m
            };
            Apartment apartment2 = new Apartment(11, 3)
            {
                RentPrice = 20000.00m
            };
            Apartment[] apartments = { apartment1, apartment2 };
            Console.WriteLine("➕ APARTMAN LİSTE➕");
            foreach (Apartment apartment in apartments)
            {
                Console.WriteLine($"Apartman NO : {apartment.ApartmentNo}");
                Console.WriteLine($"Kat         : {apartment.Floor}");
                Console.WriteLine($"Oda Sayısı  : {apartment.RoomCount}");
                Console.WriteLine($"Kira        : {apartment.RentPrice} TL");
                Console.WriteLine(new string('+',20 ));
            }

        }
    }
}