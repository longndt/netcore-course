using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Path = table.Column<string>(nullable: true),
                    AccessedAt = table.Column<DateTime>(nullable: false),
                    DurationMs = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1",
                column: "ConcurrencyStamp",
                value: "2b784a93-54f7-4318-9877-8f0608309011");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2",
                column: "ConcurrencyStamp",
                value: "0e60230d-0f5c-4e3b-b775-a75857ddaef6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e174383e-cc67-453d-8335-ed2589f911ee", "AQAAAAEAACcQAAAAEMpUCxRPaRGnBVPXr9maH77mgdnsiROQqcG95yoskPTltfiTz2FRNf9rfEAo90YWOg==", "d1d46b7a-8a68-402b-9944-ea3d7cff331e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e524b5f-6e6c-48e6-9809-d6c51a20ab80", "AQAAAAEAACcQAAAAEE2I6S5twO7TKTlEAjaCK3Ofl6W7ck8Ne/XcK9agprSkhxK4UKcAxdWJciYhh7hA1Q==", "ade3c577-d6cb-4884-b59c-295ba04f0eb2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1",
                column: "ConcurrencyStamp",
                value: "a648cc52-49a1-4955-ab15-e390601ba12c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2",
                column: "ConcurrencyStamp",
                value: "041f2952-3932-452e-9c82-5a8e63e51b36");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42291f8-236e-4324-a2a8-e4ac902cde80", "AQAAAAEAACcQAAAAENPoBzGhFZxaGHnLRBnP6OeJcBgjg65MKOCKdUkgrkNM/I21R8WKULBP+o3ODNtm/w==", "8f4b6acc-e9c4-4684-9546-41f357678c64" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "707a714b-26aa-4c9d-876b-c129892a0c45", "AQAAAAEAACcQAAAAEDUC29TwqIfj2DAhawQZu9iwLst++dzzo80l9g4F89wZneTJSk+0Njin97NhEYXlJw==", "01bb2ccf-d197-409a-a855-d6cc80231d37" });
        }
    }
}
