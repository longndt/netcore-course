using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Server.Migrations
{
    /// <inheritdoc />
    public partial class createdbseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPrice = table.Column<double>(type: "float", nullable: false),
                    BookQuantity = table.Column<int>(type: "int", nullable: false),
                    BookCover = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "BookCover", "BookPrice", "BookQuantity", "BookTitle" },
                values: new object[,]
                {
                    { 1, "https://m.media-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg", 30.0, 15, "Clean Code: A Handbook of Agile Software Craftsmanship" },
                    { 2, "https://m.media-amazon.com/images/I/41as+WafrFL._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", 35.0, 20, "The Pragmatic Programmer: Your Journey To Mastery" },
                    { 3, "https://m.media-amazon.com/images/I/81kqrwS1nNL.jpg", 20.0, 10, "You Don’t Know JS Yet: Scope & Closures" },
                    { 4, "https://m.media-amazon.com/images/I/51k+lN0RWbL._SX218_BO1,204,203,200_QL40_FMwebp_.jpg", 50.0, 5, "Design Patterns: Elements of Reusable Object-Oriented Software" },
                    { 5, "https://m.media-amazon.com/images/I/41MN80OBcBL.jpg", 75.0, 8, "Introduction to Algorithms" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");
        }
    }
}
