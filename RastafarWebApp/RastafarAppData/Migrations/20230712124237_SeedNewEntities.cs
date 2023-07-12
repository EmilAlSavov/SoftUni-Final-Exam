using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarAppData.Migrations
{
    public partial class SeedNewEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bulgaria" },
                    { 2, "Greece" },
                    { 3, "Turkey" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(2106), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m },
                    { 2, new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(2113), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m },
                    { 3, new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(2118), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m }
                });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Gradina" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 2, 2, "Saravari" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 3, 3, "Boshkaada" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 15, 6, 8, 470, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 15, 6, 8, 470, DateTimeKind.Local).AddTicks(6175));
        }
    }
}
