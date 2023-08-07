using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiparAppData.Migrations
{
    public partial class AddApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FistName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a11431d9-6e15-44c3-8600-8c64e3fdf3de", "303872f0-8de3-4c87-9fb1-89c1e4c0873b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FistName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "069f4b96-9795-42df-8e06-c4ad5e968055", 0, 16, "8eab01fc-de05-4f72-8a75-420052b8aa1a", "ApplicationUser", "embakks@gmail.com", false, "Emil", "Savov", false, null, "embakks@gmail.com", "embakks@gmail.com", "AQAAAAEAACcQAAAAEO83c1bZ1pCs54CQ1pYMls4oOhVPMcugCK5c+Xct8BE8zDKOGQaa7MTyxajEL8uskQ==", null, false, "fea41e14-2d73-4219-8480-17a0c14d289e", false, "Car Hipar" },
                    { "d41725de-66ef-4c1f-ac99-c0ac666157b6", 0, 20, "0e15a59c-1961-459d-aa1b-fe9c4fb89ee1", "ApplicationUser", "testuser@gmail.com", false, "Test", "User", false, null, "testuser@gmail.com", "testuser@gmail.com", "AQAAAAEAACcQAAAAENn5nTuADgzQM/PaAZZgSdNQqTE32W++StbI2uVXDIcIbgLSPWru9Ja/J6e+bmSo9Q==", null, false, "eac219a1-4b20-4f55-a47a-fc25ffd4c633", false, "testuser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "CampTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09cf2cea-ae76-4dbc-93b6-e4990ecce04e"), "Hammok" },
                    { new Guid("841f53b4-1909-41ff-a535-693e4e237906"), "Bungalow" },
                    { new Guid("8b017e85-c32e-4eb9-a027-3e4fafc8dbc4"), "Camper" },
                    { new Guid("e1f4a3fc-f705-40a6-8ce1-0b8f8dd8cd0e"), "Tent" },
                    { new Guid("efb113dc-ae8a-46da-9ee8-259c4a5ea319"), "Caravan" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("363b7df7-2ce7-4633-929f-fa2b92dbf1ce"), "Greece" },
                    { new Guid("5bcfadbe-f984-4856-b888-3d5a43d9b7b5"), "Bulgaria" },
                    { new Guid("77012a3a-fab9-4771-8923-45ba3ecf5d59"), "Turkey" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("7b48d700-b5fb-424b-809a-a4492b76e726"), new DateTime(2023, 8, 7, 15, 44, 7, 14, DateTimeKind.Local).AddTicks(568), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m },
                    { new Guid("825538bb-5bd7-4b90-b8a2-6ad42341d0a4"), new DateTime(2023, 8, 7, 15, 44, 7, 14, DateTimeKind.Local).AddTicks(560), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m },
                    { new Guid("b3d45ba6-6922-4928-ab6b-cd15e6297c43"), new DateTime(2023, 8, 7, 15, 44, 7, 14, DateTimeKind.Local).AddTicks(554), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m }
                });

            migrationBuilder.InsertData(
                table: "TravelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("24a7c045-06b6-437d-a837-97d623614f4a"), "Bus" },
                    { new Guid("4089ae16-68b6-4de7-b356-38b923e7a3b8"), "None" },
                    { new Guid("4ee98e2e-ea0f-44ee-8192-70eab10645b6"), "Plain" },
                    { new Guid("65360d7a-c366-4d11-bdd7-8c3e571a80e6"), "Train" },
                    { new Guid("95fac2e1-cae5-4146-bc5e-19a61485834f"), "Share Travel" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a11431d9-6e15-44c3-8600-8c64e3fdf3de", "069f4b96-9795-42df-8e06-c4ad5e968055" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("4bbaac7e-d4c6-4dc8-84ee-bb97b05ed17e"), new Guid("77012a3a-fab9-4771-8923-45ba3ecf5d59"), "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" },
                    { new Guid("e0fe10d6-f686-49d8-83d8-1fe40242dd28"), new Guid("5bcfadbe-f984-4856-b888-3d5a43d9b7b5"), "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG", "Gradina" },
                    { new Guid("ecca4fc8-b255-433a-8fd9-50de28e4cddb"), new Guid("363b7df7-2ce7-4633-929f-fa2b92dbf1ce"), "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg", "Saravari" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { new Guid("5c20bc44-66eb-4141-9cb1-3cb70625e917"), null, new Guid("efb113dc-ae8a-46da-9ee8-259c4a5ea319"), new DateTime(2023, 8, 7, 15, 44, 7, 14, DateTimeKind.Local).AddTicks(90), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "069f4b96-9795-42df-8e06-c4ad5e968055", new Guid("4ee98e2e-ea0f-44ee-8192-70eab10645b6") },
                    { new Guid("83cf8ae0-4035-4a84-aa44-7141bddc820e"), null, new Guid("e1f4a3fc-f705-40a6-8ce1-0b8f8dd8cd0e"), new DateTime(2023, 8, 7, 15, 44, 7, 13, DateTimeKind.Local).AddTicks(9985), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "069f4b96-9795-42df-8e06-c4ad5e968055", new Guid("4089ae16-68b6-4de7-b356-38b923e7a3b8") },
                    { new Guid("aaf4c632-9b8d-4834-b794-df95033016a7"), null, new Guid("8b017e85-c32e-4eb9-a027-3e4fafc8dbc4"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "d41725de-66ef-4c1f-ac99-c0ac666157b6", new Guid("4ee98e2e-ea0f-44ee-8192-70eab10645b6") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a11431d9-6e15-44c3-8600-8c64e3fdf3de", "069f4b96-9795-42df-8e06-c4ad5e968055" });

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("09cf2cea-ae76-4dbc-93b6-e4990ecce04e"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("841f53b4-1909-41ff-a535-693e4e237906"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("4bbaac7e-d4c6-4dc8-84ee-bb97b05ed17e"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("e0fe10d6-f686-49d8-83d8-1fe40242dd28"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("ecca4fc8-b255-433a-8fd9-50de28e4cddb"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("5c20bc44-66eb-4141-9cb1-3cb70625e917"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("83cf8ae0-4035-4a84-aa44-7141bddc820e"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("aaf4c632-9b8d-4834-b794-df95033016a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b48d700-b5fb-424b-809a-a4492b76e726"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("825538bb-5bd7-4b90-b8a2-6ad42341d0a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3d45ba6-6922-4928-ab6b-cd15e6297c43"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("24a7c045-06b6-437d-a837-97d623614f4a"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("65360d7a-c366-4d11-bdd7-8c3e571a80e6"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("95fac2e1-cae5-4146-bc5e-19a61485834f"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a11431d9-6e15-44c3-8600-8c64e3fdf3de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "069f4b96-9795-42df-8e06-c4ad5e968055");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d41725de-66ef-4c1f-ac99-c0ac666157b6");

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("8b017e85-c32e-4eb9-a027-3e4fafc8dbc4"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("e1f4a3fc-f705-40a6-8ce1-0b8f8dd8cd0e"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("efb113dc-ae8a-46da-9ee8-259c4a5ea319"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("363b7df7-2ce7-4633-929f-fa2b92dbf1ce"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5bcfadbe-f984-4856-b888-3d5a43d9b7b5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77012a3a-fab9-4771-8923-45ba3ecf5d59"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("4089ae16-68b6-4de7-b356-38b923e7a3b8"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("4ee98e2e-ea0f-44ee-8192-70eab10645b6"));

            migrationBuilder.DropColumn(
                name: "Age",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FistName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
    }
}
