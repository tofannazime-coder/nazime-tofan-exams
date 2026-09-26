using Microsoft.EntityFrameworkCore;
using MVC_TravelGuide.Models.Entities;

namespace MVC_TravelGuide.Models;

public class TravelGuideDbContext : DbContext
{
    public TravelGuideDbContext(DbContextOptions<TravelGuideDbContext> options)
        : base(options)
    {
    }

    public DbSet<Place> Places { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Place>().HasData(
            new Place
            {
                Id = 1,
                Name = "Topkapı Sarayı",
                City = "İstanbul",
                EntryFee = 1400
            },
            new Place
            {
                Id = 2,
                Name = "Ayasofya",
                City = "İstanbul",
                EntryFee = 0
            },
            new Place
            {
                Id = 3,
                Name = "Anıtkabir",
                City = "Ankara",
                EntryFee = 0
            },
            new Place
            {
                Id = 4,
                Name = "Pamukkale Travertenleri",
                City = "Denizli",
                EntryFee = 125
            },
            new Place
            {
                Id = 5,
                Name = "Efes Antik Kenti",
                City = "İzmir",
                EntryFee = 700
            },
            new Place
            {
                Id = 6,
                Name = "Göreme Açık Hava Müzesi",
                City = "Nevşehir",
                EntryFee = 750
            },
            new Place
            {
                Id = 7,
                Name = "Sümela Manastırı",
                City = "Trabzon",
                EntryFee = 0
            },
            new Place
            {
                Id = 8,
                Name = "Galata Kulesi",
                City = "İstanbul",
                EntryFee = 1000
            }
        );
    }
}