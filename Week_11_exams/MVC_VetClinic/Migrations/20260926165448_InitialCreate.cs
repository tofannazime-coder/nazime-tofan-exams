using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_VetClinic.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Species = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 3, "Pamuk", "Kedi" },
                    { 2, 5, "Karabaş", "Köpek" },
                    { 3, 2, "Boncuk", "Tavşan" },
                    { 4, 1, "Maviş", "Muhabbet Kuşu" },
                    { 5, 4, "Duman", "Kedi" },
                    { 6, 2, "Fındık", "Hamster" },
                    { 7, 7, "Çakıl", "Kaplumbağa" },
                    { 8, 3, "Limon", "Papağan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");
        }
    }
}
