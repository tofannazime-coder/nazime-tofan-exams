
namespace Odev26_Constructor_StudentNumber.Models;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Selin", "Duman");
        student1.Gpa = 3.35;

        Student student2 = new Student( 5466,"Yavuz", "Kaya");
        student2.Gpa = 2.85;

        Console.WriteLine("1. Öğrenci");
        Console.WriteLine($"Numara : {student1.StudentNumber}");
        Console.WriteLine($"Ad     : {student1.FirstName}");
        Console.WriteLine($"Soyad  : {student1.LastName}");
        Console.WriteLine($"Not Ortalaması : {student1.Gpa}");

        Console.WriteLine("2. Öğrenci");
        Console.WriteLine($"Numara : {student2.StudentNumber}");
        Console.WriteLine($"Ad     : {student2.FirstName}");
        Console.WriteLine($"Soyad  : {student2.LastName}");
        Console.WriteLine($"Not Ortalaması : {student2.Gpa}");

    }
}