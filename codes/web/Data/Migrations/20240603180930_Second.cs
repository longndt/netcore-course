using Microsoft.EntityFrameworkCore.Migrations;

namespace web.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1",
                column: "ConcurrencyStamp",
                value: "f4d11140-49ec-43ad-ac16-469360e6df91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2",
                column: "ConcurrencyStamp",
                value: "c6fe86f3-59d5-46be-909d-92bf1f38de36");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd746741-d2fa-49f5-b80e-5af7cac13e27", "AQAAAAEAACcQAAAAEJzXzgyGWmLz4VnGdvweEiQ7E+ZmL0Ks7SBs6moJExXkXd1sYnjPgliwufakiKyG+w==", "baa5a49c-e5bc-4137-9622-3f6f5d8111cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "164fd683-08e7-4e22-9c23-ce748c2f6d6c", "AQAAAAEAACcQAAAAECus+b9B2RgvoxXSG67LnCK6H2L3TRXHECsJgIaoQsZ0bvMnhdS42H3UOOA35VJbpA==", "2e195718-cdf5-4bf6-b77b-c274271745d8" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "GenreId", "GenreName" },
                values: new object[,]
                {
                    { 1, "Programming" },
                    { 2, "Self-help" },
                    { 3, "Novel" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1,
                column: "GenreId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2,
                column: "GenreId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3,
                column: "GenreId",
                value: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "GenreId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role1",
                column: "ConcurrencyStamp",
                value: "613b4d96-34c7-4be0-aa31-cb928595e307");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "role2",
                column: "ConcurrencyStamp",
                value: "121cea02-004b-4490-95cb-4bcd73836b0e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ea6f726-ec5f-467c-9a74-b550485fa5f9", "AQAAAAEAACcQAAAAEAt8mDVCNnM+JPVqhkfG2Mi05nY/oJ08Rd1qIXinGHI30HCS+9Z8ohIios5Er0sRSw==", "9f087f7a-a16c-45bb-95ac-f08ac76d70cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "user2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbaf9dc6-7683-4c68-a756-75b607a8875b", "AQAAAAEAACcQAAAAEEjGvHm9r/2M+cTzUwtrxZE659mkA6uWhZ1pJj/sqaLVER/pg1ksfSvF0RsxT0rcIA==", "54b21323-586b-4a97-8dc5-2f6e9c99e822" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "BookCover", "BookPrice", "BookTitle", "GenreId" },
                values: new object[,]
                {
                    { 2, "https://rukminim2.flixcart.com/image/850/1000/kkr72q80/book/k/4/l/how-to-win-friends-influence-people-international-bestseller-original-imagyf2wgzsbgvba.jpeg?q=90&crop=false", 9.9900000000000002, "How to win friends & influence people", 0 },
                    { 1, "https://images-na.ssl-images-amazon.com/images/I/51E2055ZGUL.jpg", 12.34, "Clean Code", 0 },
                    { 3, "https://nhasachphuongnam.com/images/detailed/160/81YOuOGFCJL.jpg", 6.7800000000000002, "Harry Porter", 0 }
                });
        }
    }
}
