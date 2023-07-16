using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarAppData.Migrations
{
    public partial class AddImagesToCamps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Camps",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG");

            migrationBuilder.UpdateData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg");

            migrationBuilder.UpdateData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Image", "Name" },
                values: new object[] { "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(551));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Camps");

            migrationBuilder.UpdateData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Boshkaada");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 12, 15, 42, 37, 107, DateTimeKind.Local).AddTicks(2118));
        }
    }
}
