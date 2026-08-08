using Odev38_Constructor_TaskItem.Models;
namespace Odev38_Constructor_TaskItem
{
    public class Program
    {
        static void Main(string[] args)
        {
            TaskItem task1 = new TaskItem("C# Programlama", "Nazlı Tofan", new DateTime(2026, 12, 30));
            TaskItem task2 = new TaskItem("Ofis Uygulamaları", "Ruken Şahin", new DateTime(2025, 02, 11));
            TaskItem task3 = new TaskItem("Web Tasarım", "Furkan Yıldırım", new DateTime(2026, 01, 01));

            TaskItem[] tasks = { task1, task2, task3 };

            Console.WriteLine("➕ GÖREV LİSTESİ ➕");

            foreach (TaskItem task in tasks)
            {
                Console.WriteLine($"Görev Başlığı : {task.Title}");
                Console.WriteLine($"Atanan Kişi   : {task.AssignedTo}");
                Console.WriteLine($"Son Tarih     : {task.DueDate.ToShortDateString()}");
                Console.WriteLine($"Öncelik       : {task.Priority}");
                Console.WriteLine($"Tamamlandı mı? : {task.IsCompleted}");
                Console.WriteLine(new string('+', 30));
            }

            Console.WriteLine("➕ YÜKSEK ÖNCELİKLİ (HIGH) GÖREVLER ➕");

            foreach (TaskItem task in tasks)
            {
                if (task.Priority == "High")
                {
                    Console.WriteLine($"[YÜKSEK ÖNCELİK] {task.Title} -> Atanan: {task.AssignedTo} (Son Tarih: {task.DueDate.ToShortDateString()})");
                }
            }
        }

    }
}