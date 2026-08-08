using System;
namespace Odev02_Temperature.Models
{
    public class Temperature
    {
        public double celsius { get; set; }

        public Temperature(double celsius)
        {
            celsius = celsius;
        }

        public void convertToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} Celsius is equal to {fahrenheit} Fahrenheit.");
        }
        public void convertToKelvin(double celsius)
        {
            double kelvin = celsius + 273.15;
            Console.WriteLine($"{celsius} Celsius is equal to {kelvin} Kelvin.");
        }
    }
}