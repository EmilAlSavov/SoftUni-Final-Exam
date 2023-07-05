using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarWebApp.Data.Migrations
{
    public partial class SeedPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
               table: "Posts",
               columns: new[] { "Id", "Description", "Destination", "Name", "campType", "travelType", "OwnerId" },
               values: new object[] { 1, "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "Camping in Sinemorets", 1, 1, "cd98eb91-adb9-43f2-9e74-3c201e04b4d3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
