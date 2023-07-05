using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarWebApp.Data.Migrations
{
    public partial class FirstDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Destination", "Name", "campType", "travelType" },
                values: new object[] { 1, "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "Camping in Sinemorets", 1, 1 });
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
