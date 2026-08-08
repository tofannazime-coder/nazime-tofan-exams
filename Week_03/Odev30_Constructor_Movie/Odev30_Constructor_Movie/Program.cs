using Odev30_Constructor_Movie.Models;
namespace Odev30_Constructor_Movie
{
    public class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Esaretin Bedeli", "Frank Darabont");
            movie1.Rating = 7.3;

            Movie movie2 = new Movie("Avatar", "James Cameron");
            movie2.Rating = 8.6 ;

            Movie[] movies = { movie1, movie2 };

            Console.WriteLine("➕ FİLM LİSTE ➕");

            foreach (Movie movie in movies)
            {
                Console.WriteLine($"Film Adı : {movie.Title}");
                Console.WriteLine($"Yönetmen : {movie.Director}");
                Console.WriteLine($"Süre     : {movie.DurationMinutes} dk");
                Console.WriteLine($"Puan     : {movie.Rating}");
                Console.WriteLine(new string('+', 20));
            }
        }
    }
}