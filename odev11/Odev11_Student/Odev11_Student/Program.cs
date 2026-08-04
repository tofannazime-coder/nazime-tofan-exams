using System;
using Odev11_Student.Models;

namespace Odev11_Student;

class Program
{
    static void Main(string[] args)
    {
        Student student1 = new Student();
        {
            student1.FirstName = "Nazlı";
            student1.LastName = "Tofan";
            student1.StudentNumber = 21966;
            student1.Department = "Software Engineer";
        }
        Console.WriteLine($"Ad Soyad: {student1.FirstName} {student1.LastName} Öğrenci NO: {student1.StudentNumber} Departman: {student1.Department}");

        Student student2 = new Student();
        {
            student2.FirstName = "Burak";
            student2.LastName = "Fındık";
            student2.StudentNumber = 16900;
            student2.Department = " Construction Engineer";
        }
        Console.WriteLine($"Ad Soyad: {student2.FirstName} {student2.LastName} Öğrenci NO: {student2.StudentNumber} Departman: {student2.Department}");

    }
}