using System;
namespace _01_MiniBankApp.scr.Interfaces;
public interface ITransactionLogger
{
    void Log(Guid accountId, string operation, decimal amount, decimal balanceAfter); //Yeni bir işlem gerçekleştiğinde işlemin her detayını kayıt eder.
    List<string> GetHistory(Guid accountId); //Hesabın işlem geçmişini görüntüler.
}
