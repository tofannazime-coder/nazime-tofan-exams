namespace Odev34_Constructor_Incoice.Models;

public class Program
{
    static void Main(string[] args)
    {
        Invoice invoice1 = new Invoice("FTR783928", "Evin Kaya", 765.00m);
        Invoice invoice2 = new Invoice("FTR893580", "Songül Agan", 2075.00m);

        Invoice[] invoices = { invoice1, invoice2 };

        Console.WriteLine("➕ FATURA LİSTE ➕");

        foreach (Invoice invoice in invoices)
        {
            Console.WriteLine($"Fatura NO   : {invoice.InvoiceNo}");
            Console.WriteLine($"Müşteri Ad : {invoice.CustomerName}");
            Console.WriteLine($"Tutar       : {invoice.Amount} TL");
            Console.WriteLine($"KDV Oranı   : %{invoice.TaxRate * 100}");
            Console.WriteLine($"Toplam Tutar: {invoice.TotalAmount} TL");
            Console.WriteLine(new string('+', 20));
        }
    }
}