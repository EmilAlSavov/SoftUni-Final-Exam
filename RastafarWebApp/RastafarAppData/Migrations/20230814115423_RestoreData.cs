using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiparAppData.Migrations
{
    public partial class RestoreData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { new Guid("179a7315-77b7-4abb-8272-c2b56f0ad340"), null, new Guid("BBE79E8A-016F-4C05-8BBC-5C6B39509783"), new DateTime(2023, 8, 14, 14, 54, 22, 910, DateTimeKind.Local).AddTicks(1062), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "f2734046-9c38-4662-8f40-7dfd812cc952", new Guid("A2F4B0E2-F39A-4D85-AF38-BC59F3072906") },
                    { new Guid("7b40ba82-c641-44f8-92c8-74489d5693a7"), null, new Guid("BBE79E8A-016F-4C05-8BBC-5C6B39509783"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "f2734046-9c38-4662-8f40-7dfd812cc952", new Guid("93C06FF5-DE99-462F-B2B1-5C4F4C1D4CD6") },
                    { new Guid("b5fdcec7-fd69-4c70-abf8-6bbe48274ff0"), null, new Guid("78D36457-FCE2-4DF9-AFE7-5EB5F5443B66"), new DateTime(2023, 8, 14, 14, 54, 22, 910, DateTimeKind.Local).AddTicks(991), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "c7558577-d640-43d7-b814-0a52b9d43c4e", new Guid("1A88991B-7B58-40DA-82F9-E7E15B050A9E") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("179a7315-77b7-4abb-8272-c2b56f0ad340"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("7b40ba82-c641-44f8-92c8-74489d5693a7"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b5fdcec7-fd69-4c70-abf8-6bbe48274ff0"));

           
        }
    }
}
