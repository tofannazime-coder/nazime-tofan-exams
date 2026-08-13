﻿using System;
using _01_MiniBankApp.scr.Accounts;
using _01_MiniBankApp.scr.Infrastructure;
using _01_MiniBankApp.scr.Services;

namespace _01_MiniBankApp;

class Program
{
    static void Main(string[] args)
    {
        var repository = new InMemoryAccountRepository();
        var logger = new ConsoleTransactionLogger();

        var bankService = new BankService(repository, logger);

        //HESAP AÇILIŞLAR
        var account1 = new CheckingAccount("Canan Bayar ", 0m);
        var account2 = new CheckingAccount("Zeynep Candan", 0m);

        var account3 = new SavingAccount("Osman Paşa", 0m, 2);

        
        bankService.CreateAccount(account1);
        bankService.CreateAccount(account2);
        bankService.CreateAccount(account3);

        //PARA YATIRMA
        bankService.Deposit(account1.AccountId, 2000m);

        
        bankService.Deposit(account2.AccountId, 3000m);
        bankService.Deposit(account2.AccountId, 10000m);

        bankService.Deposit(account3.AccountId, 30000m);

        //PARA ÇEKME
        bankService.Withdraw(account2.AccountId, 4000m);
        bankService.Withdraw(account2.AccountId, 1000m);
        //bankService.Withdraw(account2.AccountId, 6000m); //Limit aşıldığı için hata verdi.

        bankService.Withdraw(account3.AccountId,10000); //Vade dolmadığı için para çekilemiyor.

        //HESAPLAR ARASI TRANSFER
        bankService.Transfer(account2.AccountId, account1.AccountId, 1500m); //account2 account1'e 1500 TL transfer ediyor.

        //FAİZ HESAPLAMA
        bankService.PrintInterestReport(account1.AccountId);
        bankService.PrintInterestReport(account3.AccountId);

        //İŞLEM GEÇMİŞİ GÖRÜNTÜLEME
        var history = bankService.GetTransactionHistory(account1.AccountId);

        if (history.Count == 0)
        {
            Console.WriteLine("Henüz gerçekleşen bir işlem bulunmamaktadır.");
        }
        else
        {
            foreach (var log in history)
            {
                Console.WriteLine(log);
            }   
        }
        // TÜM HESAPLARI GÖRÜNTÜLEME
        var accounts = bankService.GetAllAccounts();

        if (accounts.Count == 0)
        {
            Console.WriteLine("Sistemde kayıtlı hesap bulunmamaktadır.");
        }
        else
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"ID: {account.AccountId} | Müşteri: {account.OwnerName} | Tür: {account.GetAccountType()} | Bakiye: {account.Balance:C2}");
            }
        }
        
    try
    {
        Guid fakeAccountId = Guid.NewGuid();

        Console.WriteLine($"[TEST] Kayıtsız ID ile para çekme deneniyor: {fakeAccountId}");
        
        bankService.Withdraw(fakeAccountId, 500m); 
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine($"\n[BAŞARILI] Yakalanan Hata Mesajı: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"\n[BEKLENMEYEN HATA]: {ex.Message}");
    }
    finally
    {
        Console.WriteLine("[SİSTEM] Hata yakalama testi tamamlandı.");
    }
    }  
}