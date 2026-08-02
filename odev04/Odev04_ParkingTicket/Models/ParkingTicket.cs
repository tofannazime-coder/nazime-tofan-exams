using System;

namespace Odev04_ParkingTicket.Models
{
    public class ParkingTicket
    {
        public String PlateNumber { get; set; }
        public DateTime EntryTime { get; set; }
        public bool IsPaid { get; set; }

        public ParkingTicket(string plateNumber, DateTime entryTime, bool isPaid)
        {
            PlateNumber = plateNumber;
            EntryTime = entryTime;
            IsPaid = isPaid;
        }

        public void CalculateFee()
        {
            TimeSpan duration = DateTime.Now - EntryTime;
            double hours = duration.TotalHours;
            double fee = 0;

            if (hours <= 1)
            {
                fee = 150; // First hour fee
            }
            else
            {
                fee = 150 + (hours - 1) * 100;
            }

            Console.WriteLine($"{PlateNumber} plakalı aracın ücreti: {fee:F2} TL");
        }

        public void Pay(decimal amount)
        {
            if (amount >= 350)
            {
                IsPaid = true;
                Console.WriteLine($"{PlateNumber} plakalı aracın ücreti ödendi.");
            }
            else
            {
                Console.WriteLine($"{PlateNumber} plakalı aracın ücreti ödenmedi. Lütfen yeterli miktarda ödeme yapın.");
            }
        }
    }


}