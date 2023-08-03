using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiparAppData.Migrations
{
    public partial class seedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85a28b32-cf73-4121-b4b6-a6488fd9895c", "6689aadb-9d4b-4db9-8fe2-857703c5acec", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "ac85b4e0-4d38-4fda-abe8-15ec72c0b140", 0, "7720fc99-4308-4beb-87f7-377ab50ec3b7", "embakks@gmail.com", false, false, null, "embakks@gmail.com", "embakks@gmail.com", "AQAAAAEAACcQAAAAEIo/uA6v9sNGZsqAvbdwO8B1ATWM0NQwLER7w5r6KCzkfk9DATJWPCHhfQKmYuPzxQ==", null, false, "bc1ad018-2ad5-42b2-bad6-5e701d63184a", false, "embakks@gmail.com" },
                    { "e3dc6c8f-c59e-4d2d-b111-4b7152c5c090", 0, "de5f540a-54da-4c08-8ea1-376b0930afee", "testuser@gmail.com", false, false, null, "testuser@gmail.com", "testuser@gmail.com", "AQAAAAEAACcQAAAAEBzO2j37D1LdLhoy21Xti/+utHE1urOKaeo6Q8pcDgkiaj67H6CtgDxFL9lvU54qRA==", null, false, "baa80c4c-52b6-420e-bbfe-475c5cfe93cf", false, "testuser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "CampTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("025e7ed2-ed13-411d-a87e-89ec78374b86"), "Hammok" },
                    { new Guid("886a4d39-d7c7-4073-a633-161538ecd89a"), "Bungalow" },
                    { new Guid("8c425ec0-0dce-4173-867d-3f4bed362320"), "Tent" },
                    { new Guid("aa8e23aa-2310-4b2b-873a-68931aee80ad"), "Camper" },
                    { new Guid("e78e1dad-af8c-47f0-8d42-bb16d43a76b9"), "Caravan" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4e22d382-cfdd-477f-80d3-f0c3d54b6b3e"), "Bulgaria" },
                    { new Guid("b75f1143-eac3-4ec9-a0e8-0fb51d51219d"), "Turkey" },
                    { new Guid("f135fd88-07fa-4c9e-b855-e66b0ad04c2b"), "Greece" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("48f61960-7011-49cf-8acf-bbc2c22eeb78"), new DateTime(2023, 8, 3, 18, 50, 37, 509, DateTimeKind.Local).AddTicks(5602), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m },
                    { new Guid("5de4dbcc-f5f0-414a-a77d-68b3c3ad4add"), new DateTime(2023, 8, 3, 18, 50, 37, 509, DateTimeKind.Local).AddTicks(5614), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m },
                    { new Guid("db3712c2-d00b-499a-aea2-1c75bd42639c"), new DateTime(2023, 8, 3, 18, 50, 37, 509, DateTimeKind.Local).AddTicks(5608), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m }
                });

            migrationBuilder.InsertData(
                table: "TravelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("175df4cd-d24f-4a3e-92d1-7b0b346b1e2a"), "Bus" },
                    { new Guid("6ebdfa94-5a18-4709-a60a-e80ea7da256b"), "Train" },
                    { new Guid("a947095c-d41b-4bed-9230-afccf99f8b40"), "Plain" },
                    { new Guid("b65fff77-dbcd-4c3c-89ae-091e83b5d3a1"), "None" },
                    { new Guid("e5445ff6-1a42-4e57-b2ac-5f7dcd8a02cf"), "Share Travel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "85a28b32-cf73-4121-b4b6-a6488fd9895c", "ac85b4e0-4d38-4fda-abe8-15ec72c0b140" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("6f0a718b-d80a-49c3-9cd2-fb32d4dc9a88"), new Guid("b75f1143-eac3-4ec9-a0e8-0fb51d51219d"), "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" },
                    { new Guid("afa0300f-222c-4ad4-bbc0-07f7d960afc4"), new Guid("f135fd88-07fa-4c9e-b855-e66b0ad04c2b"), "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg", "Saravari" },
                    { new Guid("c500e129-83e8-459c-bf5a-c339f0670be3"), new Guid("4e22d382-cfdd-477f-80d3-f0c3d54b6b3e"), "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG", "Gradina" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { new Guid("45960683-2229-4bc3-a8d0-1aa10f99b49e"), null, new Guid("aa8e23aa-2310-4b2b-873a-68931aee80ad"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "e3dc6c8f-c59e-4d2d-b111-4b7152c5c090", new Guid("a947095c-d41b-4bed-9230-afccf99f8b40") },
                    { new Guid("90fc8e80-c141-48ec-aa41-2ff936c9a509"), null, new Guid("e78e1dad-af8c-47f0-8d42-bb16d43a76b9"), new DateTime(2023, 8, 3, 18, 50, 37, 509, DateTimeKind.Local).AddTicks(5326), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "ac85b4e0-4d38-4fda-abe8-15ec72c0b140", new Guid("a947095c-d41b-4bed-9230-afccf99f8b40") },
                    { new Guid("b511b203-9799-4cd2-8700-ab0395fdf7d4"), null, new Guid("8c425ec0-0dce-4173-867d-3f4bed362320"), new DateTime(2023, 8, 3, 18, 50, 37, 509, DateTimeKind.Local).AddTicks(5285), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "ac85b4e0-4d38-4fda-abe8-15ec72c0b140", new Guid("b65fff77-dbcd-4c3c-89ae-091e83b5d3a1") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85a28b32-cf73-4121-b4b6-a6488fd9895c", "ac85b4e0-4d38-4fda-abe8-15ec72c0b140" });

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("025e7ed2-ed13-411d-a87e-89ec78374b86"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("886a4d39-d7c7-4073-a633-161538ecd89a"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("6f0a718b-d80a-49c3-9cd2-fb32d4dc9a88"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("afa0300f-222c-4ad4-bbc0-07f7d960afc4"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("c500e129-83e8-459c-bf5a-c339f0670be3"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("45960683-2229-4bc3-a8d0-1aa10f99b49e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("90fc8e80-c141-48ec-aa41-2ff936c9a509"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b511b203-9799-4cd2-8700-ab0395fdf7d4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("48f61960-7011-49cf-8acf-bbc2c22eeb78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5de4dbcc-f5f0-414a-a77d-68b3c3ad4add"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("db3712c2-d00b-499a-aea2-1c75bd42639c"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("175df4cd-d24f-4a3e-92d1-7b0b346b1e2a"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("6ebdfa94-5a18-4709-a60a-e80ea7da256b"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("e5445ff6-1a42-4e57-b2ac-5f7dcd8a02cf"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85a28b32-cf73-4121-b4b6-a6488fd9895c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac85b4e0-4d38-4fda-abe8-15ec72c0b140");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3dc6c8f-c59e-4d2d-b111-4b7152c5c090");

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("8c425ec0-0dce-4173-867d-3f4bed362320"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("aa8e23aa-2310-4b2b-873a-68931aee80ad"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("e78e1dad-af8c-47f0-8d42-bb16d43a76b9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4e22d382-cfdd-477f-80d3-f0c3d54b6b3e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b75f1143-eac3-4ec9-a0e8-0fb51d51219d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f135fd88-07fa-4c9e-b855-e66b0ad04c2b"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("a947095c-d41b-4bed-9230-afccf99f8b40"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("b65fff77-dbcd-4c3c-89ae-091e83b5d3a1"));

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
    }
}
