using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "user1", "role1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "user2", "role2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "admin-role", "f902069b-08f6-47b2-ae72-0c6900505f9b", "Admin", "ADMIN" },
                    { "reader-role", "7e75ab0c-d25f-461f-9ae3-67b7b150a709", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "admin-account", 0, "6f5c508a-9ac8-4c9d-adad-412acf402b47", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPqOs6mHfRrLDuvMkELBGjk3talFJNC1lVZFX/poXMDca09wXB2g3omdZMNetraD/g==", null, false, "5f35a4be-0f0e-4f3c-b68e-638ec0fc5a6f", false, "admin@gmail.com" },
                    { "reader-account", 0, "7be9196a-a132-4583-8ae3-ab46c5cbdd5c", "reader@gmail.com", true, false, null, "READER@GMAIL.COM", "READER@GMAIL.COM", "AQAAAAEAACcQAAAAELJ2PLDfXQI6uqD6Si8EMur+Rkxtu7fChejlsU/VOkApZZymy+TDo9R4+oGVDqG89g==", null, false, "ed6a3523-57b1-4b30-aa37-880f707acabc", false, "reader@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "admin-account", "admin-role" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "reader-account", "reader-role" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "admin-account", "admin-role" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "reader-account", "reader-role" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "admin-role");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "reader-role");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "admin-account");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "reader-account");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "role1", "2b784a93-54f7-4318-9877-8f0608309011", "Admin", "ADMIN" },
                    { "role2", "0e60230d-0f5c-4e3b-b775-a75857ddaef6", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "e174383e-cc67-453d-8335-ed2589f911ee", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMpUCxRPaRGnBVPXr9maH77mgdnsiROQqcG95yoskPTltfiTz2FRNf9rfEAo90YWOg==", null, false, "d1d46b7a-8a68-402b-9944-ea3d7cff331e", false, "admin@gmail.com" },
                    { "user2", 0, "1e524b5f-6e6c-48e6-9809-d6c51a20ab80", "reader@gmail.com", true, false, null, "READER@GMAIL.COM", "READER@GMAIL.COM", "AQAAAAEAACcQAAAAEE2I6S5twO7TKTlEAjaCK3Ofl6W7ck8Ne/XcK9agprSkhxK4UKcAxdWJciYhh7hA1Q==", null, false, "ade3c577-d6cb-4884-b59c-295ba04f0eb2", false, "reader@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "user1", "role1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "user2", "role2" });
        }
    }
}
