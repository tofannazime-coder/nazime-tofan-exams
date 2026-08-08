using System;

namespace Odev13_Product.Models;

public class Product
{
    public int ProductCode { get; set; }
    public  String Name { get; set; }
    public  String Category { get; set; }
    public decimal UnitPrice { get; set; }
}