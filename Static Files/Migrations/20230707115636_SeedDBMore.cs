using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarAppData.Migrations
{
    public partial class SeedDBMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 7, 7, 14, 56, 36, 146, DateTimeKind.Local).AddTicks(8105), "7540a0ae-e992-4280-af31-14df7178f178" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "campType", "travelType" },
                values: new object[] { 2, new DateTime(2023, 7, 7, 14, 56, 36, 146, DateTimeKind.Local).AddTicks(8150), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "7540a0ae-e992-4280-af31-14df7178f178", 3, 4 });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "campType", "travelType" },
                values: new object[] { 3, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "c8a9d004-fa89-4b96-9e40-7b58b5e5d8e8", 4, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "OwnerId" },
                values: new object[] { new DateTime(2023, 7, 6, 15, 12, 48, 320, DateTimeKind.Local).AddTicks(9924), "cd98eb91-adb9-43f2-9e74-3c201e04b4d3" });
        }
    }
}
