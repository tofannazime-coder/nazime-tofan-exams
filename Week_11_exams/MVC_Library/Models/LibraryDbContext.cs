using Microsoft.EntityFrameworkCore;
using MVC_Library.Models.Entities;

namespace MVC_Library.Models;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=12100;Database=lib_db;Username=lib_user;Password=lib_password"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Book>().HasData(
            new Book { Id = 1, Title = "Suç ve Ceza", Author = "Fyodor Dostoyevski", PageCount = 687 },
            new Book { Id = 2, Title = "Sefiller", Author = "Victor Hugo", PageCount = 1463 },
            new Book { Id = 3, Title = "1984", Author = "George Orwell", PageCount = 328 },
            new Book { Id = 4, Title = "Hayvan Çiftliği", Author = "George Orwell", PageCount = 152 },
            new Book { Id = 5, Title = "Simyacı", Author = "Paulo Coelho", PageCount = 184 },
            new Book { Id = 6, Title = "Kürk Mantolu Madonna", Author = "Sabahattin Ali", PageCount = 160 },
            new Book { Id = 7, Title = "Tutunamayanlar", Author = "Oğuz Atay", PageCount = 724 },
            new Book { Id = 8, Title = "Çalıkuşu", Author = "Reşat Nuri Güntekin", PageCount = 544 }
        );
    }
}