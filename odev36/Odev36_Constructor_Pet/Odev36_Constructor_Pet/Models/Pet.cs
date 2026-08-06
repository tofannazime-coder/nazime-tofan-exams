namespace Odev36_Constructor_Pet.Models;

public class Pet
{
    public String Name { get; set; }
    public String Type { get; set; }
    public int Age { get; set; }
    public String OwnerName { get; set; }

    public Pet(string name, string ownerName)
    {
        Name = name;
        OwnerName = ownerName;
        Type = "Unknown";
    }
    public Pet(string name, string ownerName, string type, int age)
    {
        Name = name;
        OwnerName = ownerName;
        Type = type;
        Age = age;
    }

}