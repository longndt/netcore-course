using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab1.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Laptop",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptop", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "role1", null, "Administrator", "ADMINISTRATOR" },
                    { "role2", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "user1", 0, "bc95c552-357e-441d-b9eb-a5b7222d5f4e", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEDNvyotbIFzJ/uI5EZTqlAme+m9uYkHytw95hZFcJmv3z1uIZLQU3OCtt//U2o6PQw==", null, false, "8b2993f1-0de5-495b-a6bd-f183d4e9374a", false, "admin@gmail.com" },
                    { "user2", 0, "fd6b4e19-5ea7-4172-b218-92cdb86e7ac2", "user@gmail.com", true, false, null, "USER@GMAIL.COM", "USER@GMAIL.COM", "AQAAAAIAAYagAAAAEAzsgzcSkt1UPsqZCWO4dAuA0K5KymmopTK/qFIIFairMHcvHMxW4E7Uvrhe5Cuc9g==", null, false, "243e4b5e-68ae-4177-bb50-9b564c998939", false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Laptop",
                columns: new[] { "Id", "Brand", "Image", "Model", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "Apple", "https://bizweb.dktcdn.net/100/444/581/products/macbook-m1-vs-intel-1536x1268-6c00654d-ad87-4caf-8b88-aa6c34048199.png?v=1656134590567", "Macbook Pro M2", 2345m, 10 },
                    { 3, "LG", "https://product.hstatic.net/1000333506/product/pc-gram-17z90q-b-gallery-02_dd780c6249ec430b84f82ed466fffd6e.jpg", "Gram 17", 2024m, 22 },
                    { 12, "Dell", "https://thegioiso365.vn/wp-content/uploads/2023/04/Dell-xps-9530-3.png", "XPS15", 1999m, 15 }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "role1", "user1" },
                    { "role2", "user2" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Laptop");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role1", "user1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "role2", "user2" });

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
