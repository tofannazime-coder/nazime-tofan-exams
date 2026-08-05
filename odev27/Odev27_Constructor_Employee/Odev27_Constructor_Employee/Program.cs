using Odev27_Constructor_Employee.Models;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Kübra Yılmaz");
        employee1.Salary = 40000;

        Employee employee2 = new Employee("Banu Sever", "Senior Developer");
        employee2.Salary = 90000;

        Console.WriteLine("1. Personel");
        Console.WriteLine($"Ad Soyad: {employee1.FullName}");
        Console.WriteLine($"Pozisyon: {employee1.Position}");

        Console.WriteLine("*****************************");

        Console.WriteLine("2. Personel");
        Console.WriteLine($"Ad Soyad: {employee2.FullName}");
        Console.WriteLine($"Pozisyon: {employee2.Position}");



    }
}