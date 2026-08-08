using Odev37_Constructor_CreditCard.Models;

namespace Odev37_Constructor_CreditCard;

public class Program
{
    static void Main(string[] args)
    {
        CreditCard card1 = new CreditCard("Canan Yararlı", "2344-5837-9283-1904", new DateTime(2035, 01, 01));
        CreditCard card2 = new CreditCard("Murat Kaya", "9374-8237-7456-2347", new DateTime(2040, 08, 12));

        CreditCard[] cards = { card1, card2 };


        Console.WriteLine("➕ KREDİ KART LİSTESİ ➕");

        foreach (CreditCard card in cards)
        {
            Console.WriteLine($"Kart Sahibi : {card.CardHolder}");
            Console.WriteLine($"Kart NO     : {card.CardNumber}");
            Console.WriteLine($"SKT         : {card.ExpiryDate.ToShortDateString()}");
            Console.WriteLine($"Limit       : {card.Limit:N2} TL");
            Console.WriteLine(new string('+', 30));
        }

        Console.WriteLine("➕ LİMİT KARŞILAŞTIRMASI ➕");


        if (card1.Limit > card2.Limit)
        {
            Console.WriteLine($"{card1.CardHolder} adlı kullanıcının kart limiti daha yüksek.");
        }
        else if (card2.Limit > card1.Limit)
        {
            Console.WriteLine($"{card2.CardHolder} adlı kullanıcının kart limiti daha yüksek.");
        }
        else
        {
            Console.WriteLine("İki Kart limiti eşit.");
        }

    }
}
