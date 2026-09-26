using Microsoft.EntityFrameworkCore;
using MVC_MovieArchive.Models.Entities;

namespace MVC_MovieArchive.Models;

public class MovieArchiveDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=12200;Database=movie_db;Username=movie_user;Password=movie_password"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie
            {
                Id = 1,
                Title = "Babam ve Oğlum",
                Director = "Çağan Irmak",
                ReleaseYear = 2005
            },
            new Movie
            {
                Id = 2,
                Title = "Ahlat Ağacı",
                Director = "Nuri Bilge Ceylan",
                ReleaseYear = 2018
            },
            new Movie
            {
                Id = 3,
                Title = "Eşkıya",
                Director = "Yavuz Turgul",
                ReleaseYear = 1996
            },
            new Movie
            {
                Id = 4,
                Title = "G.O.R.A.",
                Director = "Ömer Faruk Sorak",
                ReleaseYear = 2004
            },
            new Movie
            {
                Id = 5,
                Title = "Kış Uykusu",
                Director = "Nuri Bilge Ceylan",
                ReleaseYear = 2014
            },
            new Movie
            {
                Id = 6,
                Title = "Vizontele",
                Director = "Yılmaz Erdoğan",
                ReleaseYear = 2001
            },
            new Movie
            {
                Id = 7,
                Title = "Organize İşler",
                Director = "Yılmaz Erdoğan",
                ReleaseYear = 2005
            },
            new Movie
            {
                Id = 8,
                Title = "Neşeli Hayat",
                Director = "Yılmaz Erdoğan",
                ReleaseYear = 2009
            }
        );
    }
}