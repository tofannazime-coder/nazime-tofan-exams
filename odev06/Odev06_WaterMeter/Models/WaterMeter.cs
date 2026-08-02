using System;

namespace Odev06_WaterMeter.Models
{
    public class WaterMeter
    {
        public String MeterNumber { get; set; }
        public int CurrentReading { get; set; }

        public WaterMeter(string meterNumber, int currentReading)
        {
            MeterNumber = meterNumber;
            CurrentReading = currentReading;
        }
        public void ReportReading(int newReading)
        {
            if (newReading < CurrentReading)
            {
                throw new ArgumentException("Yeni değer eski değerden küçük olamaz.");
            }
            CurrentReading = newReading;
        }

        public void CalculateConsumption(int previousReading)
        {
            if (previousReading < 0)
            {
                throw new ArgumentException("Önceki değer negatif olamaz.");
            }
            int consumption = CurrentReading - previousReading;
            Console.WriteLine($"Tüketim: {consumption} birim.");
        }
    }
}