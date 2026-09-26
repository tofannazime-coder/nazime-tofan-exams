namespace MVC_CafeMenu.Models.Entities;

public class MenuItem
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public int Price { get; set; }
}