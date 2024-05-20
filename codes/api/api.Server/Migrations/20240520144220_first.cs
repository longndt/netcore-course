using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Server.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
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
                    BookCover = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { 1, "https://m.media-amazon.com/images/I/61svWgrmT0L._AC_UF1000,1000_QL80_.jpg", 25.0, 10, "The Full Stack Developer" },
                    { 2, "https://m.media-amazon.com/images/I/81iua0Wh34L._AC_UF1000,1000_QL80_.jpg", 35.0, 20, "ASP.NET Core Application Development" },
                    { 3, "https://media.springernature.com/full/springer-static/cover-hires/book/978-1-4842-3781-6", 45.0, 30, "Getting to know Vue.js" }
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
