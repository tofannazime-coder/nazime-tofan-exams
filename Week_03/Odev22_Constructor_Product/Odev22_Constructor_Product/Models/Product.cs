

namespace Odev22_Product.Models;

public class Product
{
    public Product(string name)
    {
        Name = name;
    }
    private decimal _price;
    public String Name { get; set; }
    public int Id { get; set; }
    public decimal Price
    {
        get { return _price; }
        set
        {
            if (_price < 0)
            {
                throw new ArgumentException("Fiyat Negatif Olamaz!");
            }
            _price = value;
        }
    }

}