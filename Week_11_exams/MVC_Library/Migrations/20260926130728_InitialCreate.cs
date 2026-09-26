using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Library.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Author = table.Column<string>(type: "text", nullable: true),
                    PageCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "PageCount", "Title" },
                values: new object[,]
                {
                    { 1, "Fyodor Dostoyevski", 687, "Suç ve Ceza" },
                    { 2, "Victor Hugo", 1463, "Sefiller" },
                    { 3, "George Orwell", 328, "1984" },
                    { 4, "George Orwell", 152, "Hayvan Çiftliği" },
                    { 5, "Paulo Coelho", 184, "Simyacı" },
                    { 6, "Sabahattin Ali", 160, "Kürk Mantolu Madonna" },
                    { 7, "Oğuz Atay", 724, "Tutunamayanlar" },
                    { 8, "Reşat Nuri Güntekin", 544, "Çalıkuşu" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
