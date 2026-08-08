namespace Odev31_Constructor_CoffeeOrder.Models;

public class CoffeeOrder
{
    public string CustomerName { get; set; }
    public string CoffeeType { get; set; }
    public string Size { get; set; }
    public int SugarCount { get; set; }

    public CoffeeOrder(string customerName, string coffeeType)
    {
        CustomerName = customerName;
        CoffeeType = coffeeType;
        Size = "Medium";
    }

    public CoffeeOrder(string customerName, string coffeeType, string size)
    {
         CustomerName = customerName;
        CoffeeType = coffeeType;
        Size = size;
    }

}