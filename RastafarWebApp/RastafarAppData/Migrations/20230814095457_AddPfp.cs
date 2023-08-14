using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HiparAppData.Migrations
{
    public partial class AddPfp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7970acc2-5e9e-4d34-8fc5-5a62033769d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9db8608b-f8f5-4646-8a9f-e5a5f3441a90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "faea5eb5-a96a-4472-b6d1-5ee8a6bff7dd");


            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                maxLength: 10000,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "be7e6558-3066-4712-99b6-c0ef2874fb5b", "dcea5102-ecec-4023-8e92-a53c1d11a563", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FistName", "Image", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c7558577-d640-43d7-b814-0a52b9d43c4e", 0, 20, "47c1ee8d-f3eb-43b4-98b4-933845cd96f0", "testuser@gmail.com", false, "Test", "https://scontent.xx.fbcdn.net/v/t1.15752-9/367410880_248954934732977_4076882259522423148_n.jpg?stp=dst-jpg_p180x540&_nc_cat=101&cb=99be929b-59f725be&ccb=1-7&_nc_sid=510075&_nc_ohc=7QXwtqRoJUMAX8SULHh&_nc_ad=z-m&_nc_cid=0&_nc_ht=scontent.xx&oh=03_AdRDfvnD_b7noUC6HzF2v4kUmCYjtJdBnrSOKFd_j0bnJg&oe=65016737", "User", false, null, "testuser@gmail.com", "TESTUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEJ/JmcsWKqzh3lVPGJUltm4rHro78yoKF95mEbXKrGC9Y4ZfAKNmBATF6tt3iEuzwA==", null, false, "a2973c32-1792-48ae-b789-cf430c032c4f", false, "testuser@gmail.com" },
                    { "f2734046-9c38-4662-8f40-7dfd812cc952", 0, 16, "1934f773-96bf-4881-b6cf-cd0ec51b6f16", "embakks@gmail.com", false, "Emil", "https://z-p3-scontent.fskg1-1.fna.fbcdn.net/v/t1.15752-9/367483380_254225674190931_6660571953597606357_n.jpg?_nc_cat=108&cb=99be929b-59f725be&ccb=1-7&_nc_sid=510075&_nc_ohc=cP_4NBUNEWAAX-f4BEl&_nc_ht=z-p3-scontent.fskg1-1.fna&oh=03_AdTtHrrDehU39JJDnP0CJ3F9l2R7BiAANbI1pZok2mxZ5A&oe=65016CAA", "Savov", false, null, "embakks@gmail.com", "CAR HIPAR", "AQAAAAEAACcQAAAAEP0trkfpCLtTn5chK7my/yAgjQDq8K9uhmmLip6EYm6/i84P6IBCNzvFUacYww98dQ==", null, false, "48ff2e41-0691-4057-8ba9-e69bb6c0e2a2", false, "Car Hipar" }
                });



            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "be7e6558-3066-4712-99b6-c0ef2874fb5b", "f2734046-9c38-4662-8f40-7dfd812cc952" });

            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be7e6558-3066-4712-99b6-c0ef2874fb5b", "f2734046-9c38-4662-8f40-7dfd812cc952" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be7e6558-3066-4712-99b6-c0ef2874fb5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7558577-d640-43d7-b814-0a52b9d43c4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2734046-9c38-4662-8f40-7dfd812cc952");

           
            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7970acc2-5e9e-4d34-8fc5-5a62033769d3", "faea5eb5-a96a-4472-b6d1-5ee8a6bff7dd" });


        }
    }
}
