using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GameOfThrones.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "ImagePath", "Motto", "Name", "Region", "SigilName" },
                values: new object[,]
                {
                    { 1, "/images/houses/stark.png", "Winter is coming", "House Stark", "The North", "Direwolf" },
                    { 2, "/images/houses/lannister.png", "Hear me roar", "House Lannister", "The Westerlands", "Lion" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "ActorName", "BirthDate", "CurrentAllegiance", "DeathCause", "DeathDate", "FatherId", "FirstEpisodeAppearance", "FirstName", "Gender", "HouseId", "ImagePath", "KilledById", "LastEpisodeAppearance", "LastName", "MotherId", "Nickname", "SpouseId", "Status" },
                values: new object[,]
                {
                    { 1, "Kit Harington", null, "House Stark", null, null, null, "Winter Is Coming", "Jon", 1, 1, "/images/characters/jon-snow.png", null, "The Iron Throne", "Snow", null, "King in the North", null, 1 },
                    { 2, "Peter Dinklage", null, "House Lannister", null, null, null, "Winter Is Coming", "Tyrion", 1, 2, "/images/characters/tyrion-lannister.png", null, "The Iron Throne", "Lannister", null, "The Imp", null, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
