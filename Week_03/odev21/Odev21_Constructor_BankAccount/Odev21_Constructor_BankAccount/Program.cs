using Odev21_BankAccount.Models;
namespace Odev21_BankAccount;

class Program
{
    static void Main(string[] args)
    {
        BankAccount customer1 = new BankAccount("Nazlı Fındık", 60000);
        BankAccount customer2 = new BankAccount("Burak Fındıkçı", 45000);

        Console.WriteLine($"Hesap Sahibi: {customer1.OwnerName} - Bakiye: {customer1.Balance} ");
        Console.WriteLine($"Hesap Sahibi: {customer2.OwnerName}  - Bakiye: {customer2.Balance} ");
    }
}