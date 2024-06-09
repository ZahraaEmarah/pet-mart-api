using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace pet_mart_api.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndPetRelationshipUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_User_Id",
                table: "Pet");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pet",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Pet",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_OwnerID",
                table: "Pet",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_User_OwnerID",
                table: "Pet",
                column: "OwnerID",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pet_User_OwnerID",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Pet_OwnerID",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Pet");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Pet",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_User_Id",
                table: "Pet",
                column: "Id",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
