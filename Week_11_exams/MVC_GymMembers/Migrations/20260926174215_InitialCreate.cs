using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_GymMembers.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    MembershipType = table.Column<string>(type: "text", nullable: true),
                    Age = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Age", "FullName", "MembershipType" },
                values: new object[,]
                {
                    { 1, 28, "Ahmet Yıldız", "Yıllık" },
                    { 2, 24, "Elif Kaya", "Aylık" },
                    { 3, 32, "Mehmet Demir", "3 Aylık" },
                    { 4, 27, "Zeynep Çelik", "Yıllık" },
                    { 5, 35, "Can Arslan", "Aylık" },
                    { 6, 22, "Naz Şahin", "3 Aylık" },
                    { 7, 30, "Burak Fındık", "Yıllık" },
                    { 8, 26, "Seda Tuna", "Aylık" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
