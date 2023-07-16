using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarAppData.Migrations
{
    public partial class addCampTypesAndTravelTypesAndSeedThem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "travelType",
                table: "Posts",
                newName: "TravelTypeId");

            migrationBuilder.RenameColumn(
                name: "campType",
                table: "Posts",
                newName: "CampTypeId");

            migrationBuilder.CreateTable(
                name: "CampTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelTypes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CampTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tent" },
                    { 2, "Hammok" },
                    { 3, "Caravan" },
                    { 4, "Camper" },
                    { 5, "Bungalow" }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 11, 13, 35, 3, 473, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 11, 13, 35, 3, 473, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.InsertData(
                table: "TravelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Train" },
                    { 3, "Bus" },
                    { 4, "Plain" },
                    { 5, "Share Travel" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CampTypeId",
                table: "Posts",
                column: "CampTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TravelTypeId",
                table: "Posts",
                column: "TravelTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_CampTypes_CampTypeId",
                table: "Posts",
                column: "CampTypeId",
                principalTable: "CampTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_TravelTypes_TravelTypeId",
                table: "Posts",
                column: "TravelTypeId",
                principalTable: "TravelTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_CampTypes_CampTypeId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_TravelTypes_TravelTypeId",
                table: "Posts");

            migrationBuilder.DropTable(
                name: "CampTypes");

            migrationBuilder.DropTable(
                name: "TravelTypes");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CampTypeId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TravelTypeId",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "TravelTypeId",
                table: "Posts",
                newName: "travelType");

            migrationBuilder.RenameColumn(
                name: "CampTypeId",
                table: "Posts",
                newName: "campType");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 7, 14, 56, 36, 146, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2023, 7, 7, 14, 56, 36, 146, DateTimeKind.Local).AddTicks(8150));
        }
    }
}
