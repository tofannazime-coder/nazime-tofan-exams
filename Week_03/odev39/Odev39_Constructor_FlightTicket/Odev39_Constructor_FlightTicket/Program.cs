using Odev39_Constructor_FlightTicket.Models;
namespace Odev39_Constructor_FlightTicket
{
    public class Program
    {
        static void Main(string[] args)
        {
            FlightTicket ticket1 = new FlightTicket("Sıla Tufan", "FT9473", 3000.90m);
            FlightTicket ticket2 = new FlightTicket("Fikret Can", "FT7473", 2000.60m);

            FlightTicket[] tickets = { ticket1, ticket2 };

            Console.WriteLine("➕ UÇAK BİLET LİSTESİ ➕");
            foreach (FlightTicket ticket in tickets)
            {
                Console.WriteLine($"Yolcu Adı : {ticket.PassengerName}");
                Console.WriteLine($"Sınıf     : {ticket.SeatClass}");
                Console.WriteLine($"Uçuş Kodu : {ticket.FlightCode}");
                Console.WriteLine($"Fiyat     : {ticket.Price:N2} TL");
                Console.WriteLine(new string('+', 25));
            }
        }

    }
}