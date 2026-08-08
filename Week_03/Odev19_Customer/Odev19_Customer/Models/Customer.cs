using System;
namespace Odev19_Customer.Models;
public class Customer
{
   public Customer(string name, string address, DateTime birthDate)
    {
        Name = name;
        Address = address;
        BirthDate = birthDate;  
    }
        public String Name { get; set; }
        
        public String Address { get; set; }
    public DateTime BirthDate { get; set; }
}