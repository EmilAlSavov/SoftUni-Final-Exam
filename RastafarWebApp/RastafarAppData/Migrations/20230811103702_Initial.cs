using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiparAppData.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FistName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CampTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CampTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TravelTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Camps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Camps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Camps_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    ImgsUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CampTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TravelTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CampId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_Camps_CampId",
                        column: x => x.CampId,
                        principalTable: "Camps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Posts_CampTypes_CampTypeId",
                        column: x => x.CampTypeId,
                        principalTable: "CampTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Posts_TravelTypes_TravelTypeId",
                        column: x => x.TravelTypeId,
                        principalTable: "TravelTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UsersPosts",
                columns: table => new
                {
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParticipantId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersPosts", x => new { x.PostId, x.ParticipantId });
                    table.ForeignKey(
                        name: "FK_UsersPosts_AspNetUsers_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UsersPosts_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7970acc2-5e9e-4d34-8fc5-5a62033769d3", "245d84ba-01f3-41aa-bf87-a74590a5bf32", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FistName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9db8608b-f8f5-4646-8a9f-e5a5f3441a90", 0, 20, "298fc5e9-ac50-49aa-88b3-fbca329def49", "testuser@gmail.com", false, "Test", "User", false, null, "testuser@gmail.com", "testuser@gmail.com", "AQAAAAEAACcQAAAAECbN1cxCD793XPbf+as7IkG3mAjaWrXYGeHRIQ3wIFU1Z+A/99Nj/TF2XJA5Ht14YQ==", null, false, "b72a8cd4-3e1e-4454-a2bf-880880529ac6", false, "testuser@gmail.com" },
                    { "faea5eb5-a96a-4472-b6d1-5ee8a6bff7dd", 0, 16, "6bcf315e-2704-4931-babb-a25b9225f2ce", "embakks@gmail.com", false, "Emil", "Savov", false, null, "embakks@gmail.com", "embakks@gmail.com", "AQAAAAEAACcQAAAAEO3DQ/e9lD+lYoEUEy+8hNatMskflww8Q6oLUbAvEtv3nztpOvOm4gXVbt/joTCOKQ==", null, false, "4d481796-92e7-4105-9902-c4373ab74d4c", false, "Car Hipar" }
                });

            migrationBuilder.InsertData(
                table: "CampTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2c3a03fe-c6d1-4c72-aafa-511ae5915cd2"), "Bungalow" },
                    { new Guid("32c96ed8-9b95-485a-9f9f-235a360509ef"), "Tent" },
                    { new Guid("78d36457-fce2-4df9-afe7-5eb5f5443b66"), "Hammok" },
                    { new Guid("ac159412-ddd4-4d4f-840f-6a6eda68d119"), "Caravan" },
                    { new Guid("bbe79e8a-016f-4c05-8bbc-5c6b39509783"), "Camper" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2113bc8d-3132-4150-81bf-e7563d75591a"), "Turkey" },
                    { new Guid("6e7cd032-2e6d-4416-9148-d745153b1045"), "Greece" },
                    { new Guid("9b391e9c-be11-4338-96f3-95e8f78f2fbf"), "Bulgaria" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedOn", "Description", "ImgUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("57d7bbdb-bff9-4be2-9182-507056abaaf3"), new DateTime(2023, 8, 11, 13, 37, 2, 25, DateTimeKind.Local).AddTicks(8291), "Perfect cup for campers. Just sit, take a sip and enjoy your trip. Perfect for all types of adventurers", "https://i.etsystatic.com/8120420/r/il/2b9ef1/2889698655/il_570xN.2889698655_6kgg.jpg", "Camping Cup", 15.99m },
                    { new Guid("6842067d-3fb6-4d90-b419-8844cb9e30cc"), new DateTime(2023, 8, 11, 13, 37, 2, 25, DateTimeKind.Local).AddTicks(8267), "Perfect Hammok for the summer and wild camping or just to put it in the yard to chill.", "https://www.hammockuniverse.com/cdn/shop/articles/Hammock-Universe-Blog-Featured-Image-YOUR-ULTIMATE-GUIDE-ON-HANGING-HAMMOCKS-OUTDOORS_1600x.jpg?v=1678807426", "Summar Hammok", 20.00m },
                    { new Guid("699a58ed-58be-4151-9201-74706ad2b67e"), new DateTime(2023, 8, 11, 13, 37, 2, 25, DateTimeKind.Local).AddTicks(8302), "Pocket Ashtray for wild smokers. Dont be dirty, get one of our pocket ashtray's and leave your done cigaretes there. Save nature!!!", "https://i5.walmartimages.com/asr/54a3ba02-3177-4aac-82dd-a6462dfb8d6a.7ece51e52d3dffaf8c8582c0c60c327d.jpeg?odnHeight=2000&odnWidth=2000&odnBg=ffffff", "Pocket Ashtray", 10m }
                });

            migrationBuilder.InsertData(
                table: "TravelTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1a88991b-7b58-40da-82f9-e7e15b050a9e"), "Train" },
                    { new Guid("476c562e-a630-4f7b-87c0-2b775cdd3240"), "None" },
                    { new Guid("93c06ff5-de99-462f-b2b1-5c4f4c1d4cd6"), "Share Travel" },
                    { new Guid("a2f4b0e2-f39a-4d85-af38-bc59f3072906"), "Plain" },
                    { new Guid("c212fbb1-c2cd-4243-97c8-0f33e3031eb1"), "Bus" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7970acc2-5e9e-4d34-8fc5-5a62033769d3", "faea5eb5-a96a-4472-b6d1-5ee8a6bff7dd" });

            migrationBuilder.InsertData(
                table: "Camps",
                columns: new[] { "Id", "CountryId", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("369125c5-d950-4929-9e78-ca4f4bd84da8"), new Guid("6e7cd032-2e6d-4416-9148-d745153b1045"), "https://clubvertical.net/wp-content/uploads/2022/05/20545293_1675421585825456_6037428918988778764_o.jpg", "Saravari" },
                    { new Guid("3c01fff6-f87e-45a3-a581-76843b7dfd7d"), new Guid("9b391e9c-be11-4338-96f3-95e8f78f2fbf"), "https://camping-gradina-sozopol.booked.net/data/Photos/OriginalPhoto/8480/848032/848032307/Camping-Gradina-Hotel-Sozopol-Exterior.JPEG", "Gradina" },
                    { new Guid("84228ed4-53d4-4b48-a328-bab8ef3b37da"), new Guid("2113bc8d-3132-4150-81bf-e7563d75591a"), "https://www.karavanhayati.com/wp-content/uploads/2021/03/bozcaada-karavan-kamp-alanlari-3.jpg", "Bozcaada" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CampId", "CampTypeId", "CreatedOn", "Description", "Destination", "ImgsUrl", "Name", "OwnerId", "TravelTypeId" },
                values: new object[,]
                {
                    { new Guid("021363a8-5264-4b07-975f-72da77cf1e8a"), null, new Guid("bbe79e8a-016f-4c05-8bbc-5c6b39509783"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "We are going to travel and camp from Varna to Burgas then to Sozopol, Carevo and Ahtopol", "BlackSea", "https://www.racq.com.au/-/media/project/racqgroup/racq/articles/rvs/2018/10/campervan-on-beach.jpg?h=667&iar=0&w=1000&rev=95fea142fe794fb0b6c98c2f8312e097&hash=E8405B2E92C7EFE24947186EEF7DE597", "Travel trough black sea", "9db8608b-f8f5-4646-8a9f-e5a5f3441a90", new Guid("a2f4b0e2-f39a-4d85-af38-bc59f3072906") },
                    { new Guid("6a3b8320-2d42-4513-b3e9-f1f8d04aae3b"), null, new Guid("32c96ed8-9b95-485a-9f9f-235a360509ef"), new DateTime(2023, 8, 11, 13, 37, 2, 25, DateTimeKind.Local).AddTicks(7602), "We are going to camp in the forest next to beach Butamqta in Sinemorec", "Sinemorec", "https://i.pinimg.com/originals/48/65/2a/48652a144669c357866fbb75299e95ce.jpg", "Camping in Sinemorets", "faea5eb5-a96a-4472-b6d1-5ee8a6bff7dd", new Guid("476c562e-a630-4f7b-87c0-2b775cdd3240") },
                    { new Guid("9a2a3f1f-f878-41d7-8dda-68d779281da9"), null, new Guid("ac159412-ddd4-4d4f-840f-6a6eda68d119"), new DateTime(2023, 8, 11, 13, 37, 2, 25, DateTimeKind.Local).AddTicks(7745), "We are going to camp on the beach in one of the biggest camps in bulgaria.", "Gradina", "https://camping.bg/root/f/gallery/1/c01db28c234b15fe958af37bedb1b67c.jpg", "Campers and chill in Gradina", "faea5eb5-a96a-4472-b6d1-5ee8a6bff7dd", new Guid("a2f4b0e2-f39a-4d85-af38-bc59f3072906") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Camps_CountryId",
                table: "Camps",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CampId",
                table: "Posts",
                column: "CampId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CampTypeId",
                table: "Posts",
                column: "CampTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_OwnerId",
                table: "Posts",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TravelTypeId",
                table: "Posts",
                column: "TravelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersPosts_ParticipantId",
                table: "UsersPosts",
                column: "ParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UsersPosts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Camps");

            migrationBuilder.DropTable(
                name: "CampTypes");

            migrationBuilder.DropTable(
                name: "TravelTypes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
