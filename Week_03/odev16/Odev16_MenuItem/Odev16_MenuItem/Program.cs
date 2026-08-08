
namespace Odev16_MenuItem.Models;

class Program
{
    static void Main(string[] args)
    {
        List<MenuItem> menuItems = new List<MenuItem>();
        MenuItem menuItem1 = new MenuItem("Ezogelin Çorbası", "Kırmızı mercimek, pirinç, bulgur, soğan, sarımsak, domates salçası, biber salçası ve baharatlarla hazırlanır", 230.00m, true);
        MenuItem menuItem2 = new MenuItem("Karışık Izgara", "Dana, tavuk ve köfte çeşitleriyle hazırlanan ana yemek", 550.00m, false);
        MenuItem menuItem3 = new MenuItem("Sebzeli Lazanya", "Kabak, patlıcan ve mantarla hazırlanan lazanya", 180.00m, true);
        MenuItem menuItem4 = new MenuItem("Tavuk Şiş", "Izgara tavuk şiş, pilav ve közlenmiş sebzeler ile servis edilir", 440.00m, false);
        MenuItem menuItem5 = new MenuItem("Mevsim Salatası", "Taze yeşillikler, domates, salatalık ve zeytin ile hazırlanır", 199.00m, true);

        menuItems.Add(menuItem1);
        menuItems.Add(menuItem2);
        menuItems.Add(menuItem3);
        menuItems.Add(menuItem4);
        menuItems.Add(menuItem5);


        Console.WriteLine("➕ Vejetaryen Yemekler ➕");
        foreach (MenuItem item in menuItems)
        {
            if (item.IsVegetarian)
            {
                Console.WriteLine($"{item.Name} - {item.Description} - {item.Price:C}");
            }
        }

    }

}