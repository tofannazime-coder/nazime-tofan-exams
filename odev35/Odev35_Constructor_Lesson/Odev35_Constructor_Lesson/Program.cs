using Odev35_Constructor_Lesson.Models;

namespace Odev35_Constructor_Lesson;

public class Program
{
    static void Main(string[] args)
    {
        Lesson lesson1 = new Lesson("VT455", "Veri Tabanı", "Prof. Dr. Sedat Tofan");
        lesson1.IsMandatory = true;
        Lesson lesson2 = new Lesson("WT938", "Web Tasarım", "Prof. Dr. Sıla Candan", 5, false);

        Lesson[] lessons = { lesson1, lesson2 };

        

        Console.WriteLine("➕ DERS LİSTE ➕");

        foreach (Lesson lesson in lessons)
        {
            Console.WriteLine($"Ders Kodu   : {lesson.LessonCode}");
            Console.WriteLine($"Ders Ad    : {lesson.LessonName}");
            Console.WriteLine($"Öğretmen Ad Soyad : {lesson.Instructor}");
            Console.WriteLine($"Kredi       : {lesson.Credit}");
            Console.WriteLine($"Zorunlu mu? : {lesson.IsMandatory}");
            Console.WriteLine(new string('+', 30));

        }
    }
}