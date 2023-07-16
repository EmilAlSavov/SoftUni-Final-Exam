using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarAppData.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CampTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("23c0377d-f21a-4bd3-bda3-626e55bf8e1a"), "Bungalow" },
                    { new Guid("a6dda9a8-5784-4fc5-b0b9-45ba637d685a"), "Camper" },
                    { new Guid("a7c5b466-c9fc-4136-ac5e-d5c43d4398bc"), "Hammok" },
                    { new Guid("b09b8704-8385-4b73-981c-96e2f9d59919"), "Tent" },
                    { new Guid("ef2cd45d-eb25-40ea-b4cb-50413fb3c2c7"), "Caravan" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("095ae6f5-ef2d-40a5-88d1-712b15c09d3a"), "Turkey" },
                    { new Guid("21280d70-e055-4367-9e39-99e7651a9a99"), "Greece" },
                    { new Guid("f9b5ecad-b7f4-46c9-b7c4-861f4da5a79e"), "Bulgaria" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("21b9e812-d013-41c2-b947-5a7151327834"), new DateTime(2023, 7, 16, 15, 12, 42, 3, DateTimeKind.Local).AddTicks(8501), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m },
                    { new Guid("c26d9633-fc2e-45ef-8ebe-4701ccb1c2a8"), new DateTime(2023, 7, 16, 15, 12, 42, 3, DateTimeKind.Local).AddTicks(8495), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m },
                    { new Guid("dff3a8df-c1cc-45aa-b7a6-f78eedc397a4"), new DateTime(2023, 7, 16, 15, 12, 42, 3, DateTimeKind.Local).AddTicks(8486), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "TravelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09a1f534-323c-4263-a1c4-0188a09944e7"), "None" },
                    { new Guid("5c21be1f-683d-4b6b-8ff1-0551af732c2c"), "Train" },
                    { new Guid("6a2b2824-b724-452f-9656-eb6ffc641f5b"), "Share Travel" },
                    { new Guid("89bc198d-c72d-47d5-a49e-ae84e7fc7d8b"), "Bus" },
                    { new Guid("f4477931-51f6-4f82-b04d-c1e77ba7fe51"), "Plain" }
                });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("1a8c2b9c-61d8-40b3-b805-48d6980b0d11"), new Guid("f9b5ecad-b7f4-46c9-b7c4-861f4da5a79e"), "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG", "Gradina" },
                    { new Guid("5860e207-25e6-49c0-b587-5ab07fd53cb1"), new Guid("095ae6f5-ef2d-40a5-88d1-712b15c09d3a"), "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" },
                    { new Guid("d587acc6-499a-4aed-8851-ea2bd507ff39"), new Guid("21280d70-e055-4367-9e39-99e7651a9a99"), "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg", "Saravari" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { new Guid("0db50be4-33fa-4019-b9f7-f2397c4846fe"), null, new Guid("b09b8704-8385-4b73-981c-96e2f9d59919"), new DateTime(2023, 7, 16, 15, 12, 42, 3, DateTimeKind.Local).AddTicks(8140), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "cb1ce3ef-745b-46b5-bfbb-b3ea605acc84", new Guid("09a1f534-323c-4263-a1c4-0188a09944e7") },
                    { new Guid("473901c6-2ccf-4bd2-9912-ffa34ecb853d"), null, new Guid("a6dda9a8-5784-4fc5-b0b9-45ba637d685a"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "a2590202-2ca7-4878-8903-65c6d9e02a12", new Guid("f4477931-51f6-4f82-b04d-c1e77ba7fe51") },
                    { new Guid("77899d7a-53a3-498c-b422-b7f591629064"), null, new Guid("ef2cd45d-eb25-40ea-b4cb-50413fb3c2c7"), new DateTime(2023, 7, 16, 15, 12, 42, 3, DateTimeKind.Local).AddTicks(8195), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "cb1ce3ef-745b-46b5-bfbb-b3ea605acc84", new Guid("f4477931-51f6-4f82-b04d-c1e77ba7fe51") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("23c0377d-f21a-4bd3-bda3-626e55bf8e1a"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("a7c5b466-c9fc-4136-ac5e-d5c43d4398bc"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("1a8c2b9c-61d8-40b3-b805-48d6980b0d11"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("5860e207-25e6-49c0-b587-5ab07fd53cb1"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("d587acc6-499a-4aed-8851-ea2bd507ff39"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0db50be4-33fa-4019-b9f7-f2397c4846fe"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("473901c6-2ccf-4bd2-9912-ffa34ecb853d"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("77899d7a-53a3-498c-b422-b7f591629064"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21b9e812-d013-41c2-b947-5a7151327834"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c26d9633-fc2e-45ef-8ebe-4701ccb1c2a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dff3a8df-c1cc-45aa-b7a6-f78eedc397a4"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("5c21be1f-683d-4b6b-8ff1-0551af732c2c"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("6a2b2824-b724-452f-9656-eb6ffc641f5b"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("89bc198d-c72d-47d5-a49e-ae84e7fc7d8b"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("a6dda9a8-5784-4fc5-b0b9-45ba637d685a"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("b09b8704-8385-4b73-981c-96e2f9d59919"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("ef2cd45d-eb25-40ea-b4cb-50413fb3c2c7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("095ae6f5-ef2d-40a5-88d1-712b15c09d3a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21280d70-e055-4367-9e39-99e7651a9a99"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9b5ecad-b7f4-46c9-b7c4-861f4da5a79e"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("09a1f534-323c-4263-a1c4-0188a09944e7"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4477931-51f6-4f82-b04d-c1e77ba7fe51"));
        }
    }
}
