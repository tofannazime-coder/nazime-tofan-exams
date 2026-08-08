using Odev23_Category.Models;

namespace Odev23_Category;

class Program
{
    static void Main(string[] args)
    {
        Category category1 = new Category("Kozmetik");
        category1.Description = "Makyaj, cilt bakımı ve kişisel bakım ürünleri.";

        Category category2 = new Category("Parfüm", "Kadın ve erkek parfümleri ile deodorant çeşitleri.");

        Console.WriteLine($"Kategori ismi: {category1.Name}\nAçıklama: {category1.Description}");
        Console.WriteLine("⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯⋯");
        Console.WriteLine($"Kategori ismi: {category2.Name}\nAçıklama: {category2.Description}");
    }
}