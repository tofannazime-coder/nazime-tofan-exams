using System;
using Odev20_Course.Models;



internal class Program
{
    private static void Main(string[] args)
    {
        List<Course> courses = new List<Course>
{
    new Course("CC889", "C# Programlama" , "Halit Öz", 6 ,true),
    new Course("BRK549", "Veri Tabanı" , "Nazlı Fındık", 5 ,false),
    new Course("NZT847", "Web Tasarım" , "Burak Tufan", 3 ,true),
    new Course("KSH394", "İngilizce " , "Sevgi Kıran", 4 ,false),
      };

        Console.WriteLine("➕ ONLINE DERS ➕");
        foreach (var b in courses)
        {
            if (b.IsOnline)
                Console.WriteLine($"{b.CourseCode} - {b.CourseName}");
                
        }
        Console.WriteLine("\n➕ YÜZ YÜZE DERS ➕");
        foreach (var n in courses)
        {
            if (n.IsOnline) 
            Console.WriteLine($"{n.CourseCode} - {n.CourseName}");
        }

        {

        }
    }
}