using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace superHero.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SuperHeroes",
                table: "SuperHeroes");

            migrationBuilder.RenameTable(
                name: "SuperHeroes",
                newName: "Anguler_Api");

            migrationBuilder.RenameColumn(
                name: "place",
                table: "Anguler_Api",
                newName: "testing_type");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Anguler_Api",
                newName: "technology");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Anguler_Api",
                newName: "role");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Anguler_Api",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "gender",
                table: "Anguler_Api",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phone",
                table: "Anguler_Api",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Anguler_Api",
                table: "Anguler_Api",
                column: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Anguler_Api",
                table: "Anguler_Api");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Anguler_Api");

            migrationBuilder.DropColumn(
                name: "gender",
                table: "Anguler_Api");

            migrationBuilder.DropColumn(
                name: "phone",
                table: "Anguler_Api");

            migrationBuilder.RenameTable(
                name: "Anguler_Api",
                newName: "SuperHeroes");

            migrationBuilder.RenameColumn(
                name: "testing_type",
                table: "SuperHeroes",
                newName: "place");

            migrationBuilder.RenameColumn(
                name: "technology",
                table: "SuperHeroes",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "SuperHeroes",
                newName: "FirstName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SuperHeroes",
                table: "SuperHeroes",
                column: "id");
        }
    }
}
