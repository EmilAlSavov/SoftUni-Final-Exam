using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiparAppData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7094a0a6-5f7d-4b94-9d2f-527458fab2be", 0, "9476596b-657f-4f88-bc0c-a9ad3b82dcab", "embakks@gmail.com", false, false, null, "embakks@gmail.com", "embakks@gmail.com", "AQAAAAEAACcQAAAAEJroFLQ70ScKu39/92shz4rib2/bbu1G8Al4EqrjET2k5m/GnreGnD6BCqTf7kvsOw==", null, false, "b7d41ca6-0974-4d94-b9d7-d0012316ed08", false, "embakks@gmail.com" },
                    { "843714ce-a643-480d-8540-3c2bc0667bbc", 0, "0b37014e-9071-4884-b4e3-5a7ec63f9089", "testuser@gmail.com", false, false, null, "testuser@gmail.com", "testuser@gmail.com", "AQAAAAEAACcQAAAAEK7tRPPbL3qk0wKicVKPP+YH2GLwhOWrvysgisrXR/9rrcxgj55VtMyzWcyhJ3KuOw==", null, false, "2aea6691-2af2-45fc-afd2-5ea41b562c6a", false, "testuser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "CampTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("89ae6ca1-7e3d-43cf-8c1f-d18ee77e13e7"), "Hammok" },
                    { new Guid("a31543cb-bd07-4264-ba76-ceb26291c9a7"), "Caravan" },
                    { new Guid("c01794e2-a8de-48f6-b1fa-69ae44f06b9e"), "Bungalow" },
                    { new Guid("e6ab1e2b-443c-4b62-96c2-ad092764ad9d"), "Camper" },
                    { new Guid("f83f35ae-0868-4cdd-88e9-1b0b7782c46a"), "Tent" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("9d71540c-4ef7-447d-b17c-5a17f467f129"), "Turkey" },
                    { new Guid("c82ad26f-11e7-408a-b846-4dd9fc5fc8b9"), "Bulgaria" },
                    { new Guid("ffa23271-7967-4781-a30a-fbfe19cf118e"), "Greece" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("02dd5587-ca7a-45b2-a0a6-7f719c8dcb66"), new DateTime(2023, 8, 3, 18, 41, 44, 848, DateTimeKind.Local).AddTicks(1992), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m },
                    { new Guid("2ac68360-969f-492c-9521-97b550a82844"), new DateTime(2023, 8, 3, 18, 41, 44, 848, DateTimeKind.Local).AddTicks(1999), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m },
                    { new Guid("7239f6d3-ba3c-4b18-afc0-e224eccda299"), new DateTime(2023, 8, 3, 18, 41, 44, 848, DateTimeKind.Local).AddTicks(2009), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m }
                });

            migrationBuilder.InsertData(
                table: "TravelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("005d2e28-aaa7-4cfe-af53-4b06c62684f9"), "Bus" },
                    { new Guid("18d54f95-8d61-49a0-a857-2110dba3bb0a"), "Plain" },
                    { new Guid("96c5a959-cca8-4b4f-a29a-2fac84e8d9b4"), "Share Travel" },
                    { new Guid("cdc3c48d-3dd9-4f83-ad1f-5d4cbef2994e"), "None" },
                    { new Guid("f1da36e5-b57b-44d6-b18e-7ca4aa8a1818"), "Train" }
                });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("48dd2f06-4c5b-44c2-81a4-063dda2b5eaa"), new Guid("c82ad26f-11e7-408a-b846-4dd9fc5fc8b9"), "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG", "Gradina" },
                    { new Guid("75b1fc94-aeeb-4512-8ac1-47cf6c656e7e"), new Guid("9d71540c-4ef7-447d-b17c-5a17f467f129"), "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" },
                    { new Guid("dc01aad4-f96c-4dcd-93b9-ccf567ecacb8"), new Guid("ffa23271-7967-4781-a30a-fbfe19cf118e"), "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg", "Saravari" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { new Guid("108f873b-0680-4ff4-976f-74654aeb544a"), null, new Guid("a31543cb-bd07-4264-ba76-ceb26291c9a7"), new DateTime(2023, 8, 3, 18, 41, 44, 848, DateTimeKind.Local).AddTicks(1622), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "7094a0a6-5f7d-4b94-9d2f-527458fab2be", new Guid("18d54f95-8d61-49a0-a857-2110dba3bb0a") },
                    { new Guid("23669b8d-0b9b-43ab-ae09-ddbc63bfa1d8"), null, new Guid("f83f35ae-0868-4cdd-88e9-1b0b7782c46a"), new DateTime(2023, 8, 3, 18, 41, 44, 848, DateTimeKind.Local).AddTicks(1580), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "7094a0a6-5f7d-4b94-9d2f-527458fab2be", new Guid("cdc3c48d-3dd9-4f83-ad1f-5d4cbef2994e") },
                    { new Guid("f80fd2be-fcce-4383-80d4-bdb4a6c6820a"), null, new Guid("e6ab1e2b-443c-4b62-96c2-ad092764ad9d"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "843714ce-a643-480d-8540-3c2bc0667bbc", new Guid("18d54f95-8d61-49a0-a857-2110dba3bb0a") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("89ae6ca1-7e3d-43cf-8c1f-d18ee77e13e7"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("c01794e2-a8de-48f6-b1fa-69ae44f06b9e"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("48dd2f06-4c5b-44c2-81a4-063dda2b5eaa"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("75b1fc94-aeeb-4512-8ac1-47cf6c656e7e"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("dc01aad4-f96c-4dcd-93b9-ccf567ecacb8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("108f873b-0680-4ff4-976f-74654aeb544a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("23669b8d-0b9b-43ab-ae09-ddbc63bfa1d8"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f80fd2be-fcce-4383-80d4-bdb4a6c6820a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02dd5587-ca7a-45b2-a0a6-7f719c8dcb66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2ac68360-969f-492c-9521-97b550a82844"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7239f6d3-ba3c-4b18-afc0-e224eccda299"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("005d2e28-aaa7-4cfe-af53-4b06c62684f9"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("96c5a959-cca8-4b4f-a29a-2fac84e8d9b4"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("f1da36e5-b57b-44d6-b18e-7ca4aa8a1818"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7094a0a6-5f7d-4b94-9d2f-527458fab2be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "843714ce-a643-480d-8540-3c2bc0667bbc");

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("a31543cb-bd07-4264-ba76-ceb26291c9a7"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("e6ab1e2b-443c-4b62-96c2-ad092764ad9d"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("f83f35ae-0868-4cdd-88e9-1b0b7782c46a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9d71540c-4ef7-447d-b17c-5a17f467f129"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c82ad26f-11e7-408a-b846-4dd9fc5fc8b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ffa23271-7967-4781-a30a-fbfe19cf118e"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("18d54f95-8d61-49a0-a857-2110dba3bb0a"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("cdc3c48d-3dd9-4f83-ad1f-5d4cbef2994e"));

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
    }
}
