using System;

namespace Odev04_ParkingTicket.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            ParkingTicket ticket= new ParkingTicket("34ABC123", DateTime.Now.AddHours(-2), false);
            ticket.CalculateFee();
            ticket.Pay(250);
            ticket.Pay(350);
        }
    }
}