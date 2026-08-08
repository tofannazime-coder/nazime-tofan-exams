using System;

namespace Odev02_Temperature.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Temperature temp1 = new Temperature(0);
        temp1.convertToFahrenheit(0);
        temp1.convertToKelvin(0);
        Temperature temp2 = new Temperature(25);
        temp2.convertToFahrenheit(25);
        temp2.convertToKelvin(25);
        Temperature temp3 = new Temperature(-40);
        temp3.convertToFahrenheit(-40);
        temp3.convertToKelvin(-40);
    }


}