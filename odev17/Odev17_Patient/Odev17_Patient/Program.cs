namespace Odev17_Patient.Models;

class Program
{
    static void Main(string[] args)
    {
        Patient patient1 = new Patient(1, "Pelin Dönmez" , new DateTime(2000 ,4,2), "A+");
        Patient patient2 = new Patient(2, "Burak Sever" , new DateTime(1997 ,5,2), "A-");
        

        Console.WriteLine(" •••• Hasta Bilgileri ••••");
         Console.WriteLine($"{patient1.PatientId}. Hasta Bilgi : Ad Soyad: {patient1.FullName}, Kan Grubu: {patient1.BloodType}");
        Console.WriteLine($"{patient2.PatientId}. Hasta Bilgi: Ad Soyad: {patient2.FullName}, Kan Grubu: {patient2.BloodType}");

    }
}