using System;

namespace Odev09_EmailDraft.Models
{
    public class Program
    {
        static void Main(string[] args)
        {

            
            EmailDraft email = new EmailDraft("", "", "Merhaba");

            email.Send();

            Console.WriteLine("----------------");

            email.To = "ornek@gmail.com";
            email.Subject = "Deneme";

            email.Send();

            Console.WriteLine("----------------");

          
            email.UpdateBody("Yeni mail içeriği");
           
           Console.ReadLine();
        }
    }
}