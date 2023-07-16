using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarAppData.Migrations
{
    public partial class insertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "campType", "travelType" },
                values: new object[] { 1, "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "7540a0ae-e992-4280-af31-14df7178f178", 1, 1 });

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
