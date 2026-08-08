using System;


namespace Odev10_BankAccount.Models;
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Burak Fındık");
            account.ShowInfo();

            account.Deposit(2500);
            account.Deposit(7000);
            account.WithDraw(3000);

            bool result = account.WithDraw(20000);

            if (result)
            {
                Console.WriteLine("Para çekme başarılı.");

            }
            else
            {
                Console.WriteLine("Yetersiz bakiye, başarısız");
            }
            Console.WriteLine($"Güncel Bakiye: {account.Balance} TL");

        }
    }
