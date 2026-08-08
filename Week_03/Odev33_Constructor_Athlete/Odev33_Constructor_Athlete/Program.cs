namespace Odev33_Constructor_Athlete.Models;

public class Program
{
    static void Main(string[] args)
    {
        Athlete athlete1 = new Athlete("Cristiano Ronaldo", "Futbol" );
        Athlete athlete2 = new Athlete("Lionel Messi", "Futbol", "Inter Miami", 10);

        Athlete[] athletes = { athlete1, athlete2 };

        Console.WriteLine("➕ TAKIM KARŞILAŞTIRILMASI ➕");

        foreach (Athlete athlete in athletes)
        {
            Console.WriteLine($"Sporcu Ad : {athlete.FullName}");
            Console.WriteLine($"Branş      : {athlete.SportBranch}");
            Console.WriteLine($"Takım      : {athlete.TeamName}");
            Console.WriteLine($"Forma NO  : {athlete.JerseyNumber}");
            Console.WriteLine(new string('+', 20));
        }
    }
}