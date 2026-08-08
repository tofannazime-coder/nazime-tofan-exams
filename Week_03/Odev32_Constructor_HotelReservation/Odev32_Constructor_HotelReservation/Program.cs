namespace Odev32_Constructor_HotelReservation.Models;

public class Program
{
    static void Main(string[] args)
    {
        HotelReservation hotelReservation1 = new HotelReservation("Nazlı Tofan", 202, DateTime.Now);
        hotelReservation1.TotalPrice = 3500;

        HotelReservation hotelReservation2 = new HotelReservation("Burak Fındık", 203, DateTime.Now, 2);
        hotelReservation2.TotalPrice = 3600 * 2;

        HotelReservation[] hotelReservations = { hotelReservation1, hotelReservation2 };

        Console.WriteLine("➕ OTEL REZERVASYON ➕");

        foreach (HotelReservation hotelReservation in hotelReservations)
        {
            Console.WriteLine($"Müşteri Ad : {hotelReservation.GuestName}");
            Console.WriteLine($"Oda NO    : {hotelReservation.RoomNumber}");
            Console.WriteLine($"Giriş Tarihi: {hotelReservation.CheckInDate.ToShortDateString()}");
            Console.WriteLine($"Gece Sayısı : {hotelReservation.NightCount}");
            Console.WriteLine($"Toplam Tutar: {hotelReservation.TotalPrice} TL");
            Console.WriteLine(new string('+', 20));
        }
    }
}

