using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(nullable: true),
                    BookPrice = table.Column<double>(nullable: false),
                    BookCover = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "role1", "fc5bfcb6-37f4-4fa1-be35-c54d348fbd70", "Admin", "ADMIN" },
                    { "role2", "fb2c75b2-5794-4247-8ace-de1c5e8dd486", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "54e31a64-612c-4b3b-81fa-0bf2081e4b71", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMYWPGPcZl05bLGwO0QHL6Z4Q6HwpFDH6U3PoPvrTBuHTpOkkIPJgmmSMP76DKprkw==", null, false, "493bc75c-2cc1-46df-b2a1-0792d5ddf817", false, "admin@gmail.com" },
                    { "user2", 0, "ea1a4755-e1e2-49bc-b665-863cf2c92396", "reader@gmail.com", true, false, null, "READER@GMAIL.COM", "READER@GMAIL.COM", "AQAAAAEAACcQAAAAEKvzye/RXxfJdVz/nDcSxdMqnMihRUPhnFS2sJfd7Kc9HcNMm3sndvsRyTUiOR+JtA==", null, false, "33e1021d-5534-48a0-a5b6-d586feb024b0", false, "reader@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "BookCover", "BookPrice", "BookTitle" },
                values: new object[,]
                {
                    { 1, "https://images-na.ssl-images-amazon.com/images/I/51E2055ZGUL.jpg", 12.34, "Clean Code" },
                    { 2, "https://rukminim2.flixcart.com/image/850/1000/kkr72q80/book/k/4/l/how-to-win-friends-influence-people-international-bestseller-original-imagyf2wgzsbgvba.jpeg?q=90&crop=false", 9.9900000000000002, "How to win friends & influence people" },
                    { 3, "https://nhasachphuongnam.com/images/detailed/160/81YOuOGFCJL.jpg", 6.7800000000000002, "Harry Porter" }
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

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
        }
    }
}
