using System;

namespace Odev05_GradeBook.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Öğrenci adını giriniz: ");
            string studentName = Console.ReadLine();
            GradeBook gradeBook = new GradeBook(studentName);

            while (true)
            {
                Console.WriteLine("Sınav puanını giriniz (çıkmak için 'q' tuşuna basın): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                if (int.TryParse(input, out int score))
                {
                    try
                    {
                        gradeBook.AddExamScore(score);
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı giriniz.");
                }
            }

            try
            {
                double averageScore = gradeBook.GetAverageScore();
                Console.WriteLine($"Öğrenci: {gradeBook.StudentName}, Ortalama Puan: {averageScore:F2}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            } 
        }
    }
}