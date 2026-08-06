namespace Odev34_Constructor_Incoice.Models;

public class Invoice
{
    public String InvoiceNo { get; set; }
    public String CustomerName { get; set; }
    public decimal Amount { get; set; }
    public decimal TaxRate { get; set; }

    public decimal TotalAmount
    {
        get
        {
            return Amount + (Amount * TaxRate);
        }
    }

    public Invoice(string invoiceNo, string customerName, decimal amount)
    {
        InvoiceNo = invoiceNo;
        CustomerName = customerName;
        Amount = amount;
        TaxRate = 0.20m;
    }

    public Invoice(string invoiceNo, string customerName, decimal amount, decimal taxRate)
    {
        InvoiceNo = invoiceNo;
        CustomerName = customerName;
        Amount = amount;
        TaxRate = taxRate;
    }

}