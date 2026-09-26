using System;
using Microsoft.EntityFrameworkCore;
using MVC_VetClinic.Models.Entities;

namespace MVC_VetClinic.Models;

public class VetClinicDbContext : DbContext
{
    public DbSet<Pet> Pets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=12300;Database=vet_db;Username=vet_user;Password=vet_password"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pet>().HasData(
            new Pet
            {
                Id = 1,
                Name = "Pamuk",
                Species = "Kedi",
                Age = 3
            },
            new Pet
            {
                Id = 2,
                Name = "Karabaş",
                Species = "Köpek",
                Age = 5
            },
            new Pet
            {
                Id = 3,
                Name = "Boncuk",
                Species = "Tavşan",
                Age = 2
            },
            new Pet
            {
                Id = 4,
                Name = "Maviş",
                Species = "Muhabbet Kuşu",
                Age = 1
            },
            new Pet
            {
                Id = 5,
                Name = "Duman",
                Species = "Kedi",
                Age = 4
            },
            new Pet
            {
                Id = 6,
                Name = "Fındık",
                Species = "Hamster",
                Age = 2
            },
            new Pet
            {
                Id = 7,
                Name = "Çakıl",
                Species = "Kaplumbağa",
                Age = 7
            },
            new Pet
            {
                Id = 8,
                Name = "Limon",
                Species = "Papağan",
                Age = 3
            }
        );
    }
}