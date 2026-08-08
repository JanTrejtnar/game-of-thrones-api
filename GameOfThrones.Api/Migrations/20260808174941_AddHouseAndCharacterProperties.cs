using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOfThrones.Api.Migrations
{
    /// <inheritdoc />
    public partial class AddHouseAndCharacterProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Motto",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Region",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SigilName",
                table: "Houses",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Motto",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "Region",
                table: "Houses");

            migrationBuilder.DropColumn(
                name: "SigilName",
                table: "Houses");
        }
    }
}
