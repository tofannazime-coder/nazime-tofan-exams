using System;

namespace Odev10_BankAccount
{
    public class BankAccount
    {
        private String ownerName;
        private decimal balance;

        public BankAccount(string ownerName)
        {
            this.ownerName = ownerName;
            balance = 0;
        }

        public decimal Balance
        {
            get { return balance; }
            private set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }


        public bool WithDraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Hesap Sahibi: {ownerName}");
            Console.WriteLine($"Bakiye: {Balance} TL");
        }
    }
}