using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_MovieArchive.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Director = table.Column<string>(type: "text", nullable: false),
                    ReleaseYear = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Director", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 1, "Çağan Irmak", 2005, "Babam ve Oğlum" },
                    { 2, "Nuri Bilge Ceylan", 2018, "Ahlat Ağacı" },
                    { 3, "Yavuz Turgul", 1996, "Eşkıya" },
                    { 4, "Ömer Faruk Sorak", 2004, "G.O.R.A." },
                    { 5, "Nuri Bilge Ceylan", 2014, "Kış Uykusu" },
                    { 6, "Yılmaz Erdoğan", 2001, "Vizontele" },
                    { 7, "Yılmaz Erdoğan", 2005, "Organize İşler" },
                    { 8, "Yılmaz Erdoğan", 2009, "Neşeli Hayat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
