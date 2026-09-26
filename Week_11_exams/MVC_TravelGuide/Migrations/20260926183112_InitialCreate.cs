using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_TravelGuide.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    EntryFee = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "Id", "City", "EntryFee", "Name" },
                values: new object[,]
                {
                    { 1, "İstanbul", 1400, "Topkapı Sarayı" },
                    { 2, "İstanbul", 0, "Ayasofya" },
                    { 3, "Ankara", 0, "Anıtkabir" },
                    { 4, "Denizli", 125, "Pamukkale Travertenleri" },
                    { 5, "İzmir", 700, "Efes Antik Kenti" },
                    { 6, "Nevşehir", 750, "Göreme Açık Hava Müzesi" },
                    { 7, "Trabzon", 0, "Sümela Manastırı" },
                    { 8, "İstanbul", 1000, "Galata Kulesi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
