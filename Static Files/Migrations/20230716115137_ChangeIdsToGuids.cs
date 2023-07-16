using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RastafarAppData.Migrations
{
    public partial class ChangeIdsToGuids : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Camps_CampId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: 5);

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
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
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
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AlterColumn<Guid>(
                name: "PostId",
                table: "UsersPosts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "TravelTypes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "TravelTypeId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "CampTypeId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "CampId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Countries",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "CampTypes",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<Guid>(
                name: "CountryId",
                table: "Camps",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Camps",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "CampTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("10acb856-f9b1-416c-a422-094b351111da"), "Bungalow" },
                    { new Guid("1ceb85b7-ff4a-4bd3-befe-067e3a7688ae"), "Tent" },
                    { new Guid("34f8783d-b4dd-4ae4-bb3d-d47c6728a2de"), "Camper" },
                    { new Guid("453055e3-7958-4926-824e-815666d68149"), "Hammok" },
                    { new Guid("f4622d97-e7c8-477f-aedd-993ecd8d7cb3"), "Caravan" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0132a7a6-25c2-4bcc-b0a7-5304ea02d36b"), "Greece" },
                    { new Guid("40e209ff-596f-4256-8059-fc430ee66146"), "Bulgaria" },
                    { new Guid("6fa7c81f-4b8b-43b7-ba69-b9362641871a"), "Turkey" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2d14d2bb-f8dc-496b-b322-0ad1d994ab61"), new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4877), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m },
                    { new Guid("8bd7c7d5-1046-4f86-9d91-025eb9ce780c"), new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4856), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m },
                    { new Guid("ad6ae157-ff89-4feb-99ed-aaadcd564c4c"), new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4864), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m }
                });

            migrationBuilder.InsertData(
                table: "TravelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1f32b3af-7440-4b6d-95c7-b0cc71c0d93d"), "Bus" },
                    { new Guid("8fe54c2b-b2bd-4a17-9616-fc06ccc1c6b9"), "None" },
                    { new Guid("a4aedb8c-a41d-4df8-b013-86b6f742a541"), "Share Travel" },
                    { new Guid("b398d39e-489b-40c8-8159-f16705da934e"), "Train" },
                    { new Guid("f1eff442-fedf-4e9c-b991-fe1d7dcc5623"), "Plain" }
                });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("4a79fcd8-56ba-4041-ab4f-7245cdda8f37"), new Guid("6fa7c81f-4b8b-43b7-ba69-b9362641871a"), "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" },
                    { new Guid("af351011-87e8-4a41-b71d-563e43bf0ab6"), new Guid("0132a7a6-25c2-4bcc-b0a7-5304ea02d36b"), "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg", "Saravari" },
                    { new Guid("ca575d4d-3bdd-4617-af8b-3697e530931a"), new Guid("40e209ff-596f-4256-8059-fc430ee66146"), "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG", "Gradina" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { new Guid("0b6a58ab-d0f7-4300-9018-43aea2b18d84"), null, new Guid("34f8783d-b4dd-4ae4-bb3d-d47c6728a2de"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "c8a9d004-fa89-4b96-9e40-7b58b5e5d8e8", new Guid("f1eff442-fedf-4e9c-b991-fe1d7dcc5623") },
                    { new Guid("55023207-ba7b-4860-b8e5-96a5619a8b28"), null, new Guid("f4622d97-e7c8-477f-aedd-993ecd8d7cb3"), new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4572), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "7540a0ae-e992-4280-af31-14df7178f178", new Guid("f1eff442-fedf-4e9c-b991-fe1d7dcc5623") },
                    { new Guid("6b11959e-5f0f-4579-be3e-943eef22dfdd"), null, new Guid("1ceb85b7-ff4a-4bd3-befe-067e3a7688ae"), new DateTime(2023, 7, 16, 14, 51, 36, 908, DateTimeKind.Local).AddTicks(4524), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "7540a0ae-e992-4280-af31-14df7178f178", new Guid("8fe54c2b-b2bd-4a17-9616-fc06ccc1c6b9") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Camps_CampId",
                table: "Posts",
                column: "CampId",
                principalTable: "Camps",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Camps_CampId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("10acb856-f9b1-416c-a422-094b351111da"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("453055e3-7958-4926-824e-815666d68149"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("4a79fcd8-56ba-4041-ab4f-7245cdda8f37"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("af351011-87e8-4a41-b71d-563e43bf0ab6"));

            migrationBuilder.DeleteData(
                table: "Camps",
                keyColumn: "Id",
                keyValue: new Guid("ca575d4d-3bdd-4617-af8b-3697e530931a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0b6a58ab-d0f7-4300-9018-43aea2b18d84"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("55023207-ba7b-4860-b8e5-96a5619a8b28"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6b11959e-5f0f-4579-be3e-943eef22dfdd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d14d2bb-f8dc-496b-b322-0ad1d994ab61"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8bd7c7d5-1046-4f86-9d91-025eb9ce780c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad6ae157-ff89-4feb-99ed-aaadcd564c4c"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("1f32b3af-7440-4b6d-95c7-b0cc71c0d93d"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("a4aedb8c-a41d-4df8-b013-86b6f742a541"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("b398d39e-489b-40c8-8159-f16705da934e"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("1ceb85b7-ff4a-4bd3-befe-067e3a7688ae"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("34f8783d-b4dd-4ae4-bb3d-d47c6728a2de"));

            migrationBuilder.DeleteData(
                table: "CampTypes",
                keyColumn: "Id",
                keyValue: new Guid("f4622d97-e7c8-477f-aedd-993ecd8d7cb3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0132a7a6-25c2-4bcc-b0a7-5304ea02d36b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("40e209ff-596f-4256-8059-fc430ee66146"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6fa7c81f-4b8b-43b7-ba69-b9362641871a"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("8fe54c2b-b2bd-4a17-9616-fc06ccc1c6b9"));

            migrationBuilder.DeleteData(
                table: "TravelTypes",
                keyColumn: "Id",
                keyValue: new Guid("f1eff442-fedf-4e9c-b991-fe1d7dcc5623"));

            migrationBuilder.AlterColumn<int>(
                name: "PostId",
                table: "UsersPosts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "TravelTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "TravelTypeId",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "CampTypeId",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "CampId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Countries",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "CampTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Camps",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Camps",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

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

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bulgaria" },
                    { 2, "Greece" },
                    { 3, "Turkey" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(526), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m },
                    { 2, new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(544), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m },
                    { 3, new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(551), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m }
                });

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

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Image", "Name" },
                values: new object[,]
                {
                    { 1, 1, "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG", "Gradina" },
                    { 2, 2, "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg", "Saravari" },
                    { 3, 3, "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { 1, 0, 1, new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(38), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "7540a0ae-e992-4280-af31-14df7178f178", 1 },
                    { 2, 0, 3, new DateTime(2023, 7, 12, 16, 56, 52, 919, DateTimeKind.Local).AddTicks(96), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "7540a0ae-e992-4280-af31-14df7178f178", 4 },
                    { 3, 0, 4, new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "c8a9d004-fa89-4b96-9e40-7b58b5e5d8e8", 4 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Camps_CampId",
                table: "Posts",
                column: "CampId",
                principalTable: "Camps",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
