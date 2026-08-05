namespace Odev25_Student.Models;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student("Nur" , "Hayat");
        student1.StudentNumber = "894";
        student1.Department = "PDR";

           Student student2 = new Student("Muratcan" , "Kartal");
        student2.StudentNumber = "380";
        student2.Department = "Bilgisayar Mühendisliği";
        
 Console.WriteLine($" 1) Öğrenci Ad: {student1.FirstName}  {student1.LastName} - NO: {student1.StudentNumber} - Bölüm: {student1.Department}");
 Console.WriteLine("-------------------------------------------------");
 Console.WriteLine($" 2) Öğrenci Ad: {student2.FirstName}  {student2.LastName} - NO: {student2.StudentNumber} - Bölüm: {student2.Department}");
    }
}