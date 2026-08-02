using System;

namespace Odev06_WaterMeter.Models
{
    public class Program

    {
        static void Main(string[] args)
        {
            WaterMeter meter = new WaterMeter("020307", 1000);
            Console.WriteLine($"Sayaç Numarası: {meter.MeterNumber}, Mevcut Okuma: {meter.CurrentReading}");

            try
            {
                meter.ReportReading(1250); // Yeni okuma rapor ediliyor
                Console.WriteLine($"Yeni Okuma: {meter.CurrentReading}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                meter.CalculateConsumption(1000);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}