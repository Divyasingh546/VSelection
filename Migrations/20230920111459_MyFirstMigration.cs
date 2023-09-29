using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class MyFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VCharacters",
                columns: table => new
                {
                    VRegistrationNumber = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VName = table.Column<string>(type: "TEXT", nullable: false),
                    VQuantity = table.Column<string>(type: "TEXT", nullable: false),
                    VModel = table.Column<string>(type: "TEXT", nullable: false),
                    Vcolor = table.Column<string>(type: "TEXT", nullable: false),
                    VYearOfManufacture = table.Column<int>(type: "INTEGER", nullable: false),
                    VImage = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VCharacters", x => x.VRegistrationNumber);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VCharacters");
        }
    }
}
