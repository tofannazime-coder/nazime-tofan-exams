using Odev14_Event.Models;

List<Event> events = new List<Event>
        {
            new Event
            {
                Title = "Kitap Fuarı",
                Location = "TÜYAP Fuar Merkezi",
                EventDate = DateTime.Now.AddDays(9),
                Capacity = 1000
            },
            new Event
            {
                Title = "Film Gösterimi ",
                Location = "Kültür Merkezi",
                EventDate = DateTime.Now.AddDays(20),
                Capacity = 350
            }
        };
Console.WriteLine("Gelecek Etkinlikleri:");
Console.WriteLine("*******");
foreach (var b in events)
{
    Console.WriteLine($"Title: {b.Title}");
    Console.WriteLine($"Location: {b.Location}");
    Console.WriteLine($"Date: {b.EventDate}");
    Console.WriteLine($"Capacity: {b.Capacity}");
    Console.WriteLine();
}