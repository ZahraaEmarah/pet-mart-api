using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace pet_mart_api.Migrations
{
    /// <inheritdoc />
    public partial class PetUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Breed",
                table: "Pet",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Pet",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Likes",
                table: "Pet",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "Vaccinated",
                table: "Pet",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Breed",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Likes",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "Vaccinated",
                table: "Pet");
        }
    }
}
