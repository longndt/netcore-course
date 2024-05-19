using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6823808a-4811-4f5f-aa66-77d4482ac2a8", "AQAAAAIAAYagAAAAENA8ggCLUZk4wMNQg6ElSmATt/hsWBtsJV1Ak6O09VyauwpWsfGfUNowGAWaN172GQ==", "25db35e3-3695-49e1-a1b0-1d5374f3f4a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "628b0726-0c0c-49f5-b1ae-635dd0032ed5", "AQAAAAIAAYagAAAAEAdsuOT4olJCJsgQPfv0UzzlCtrONXVPhC9YrRPpeQz1HvByz+kgvNklFvvfuemXkg==", "a492d6cb-10f7-45a9-836d-d6d17fdadd6c" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DepartmentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DepartmentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "DepartmentId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb89fecb-3219-4f8b-a6cd-bae32d1baa4a", "AQAAAAIAAYagAAAAEACaPw+/kw6EF3LrDc5m/2sW+R2ViumFui8eIz6lHEFhqew+DKH4eCT14KR9y7BAhA==", "3bb5720f-25e3-407a-9647-04d2b5cf921f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5def8954-fd7d-44e1-9aca-8b4d97a42d5a", "AQAAAAIAAYagAAAAEPAqSjrFtXJHB2Lttt2mfNBzTfYcL0Z37+ZLDWUx+F1RedfhQcN/6OKSk2TLn6tcjg==", "908ce22a-3cac-4a5a-9b69-017c6cd88b4f" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 1,
                column: "DepartmentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 2,
                column: "DepartmentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 3,
                column: "DepartmentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 4,
                column: "DepartmentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "StudentId",
                keyValue: 5,
                column: "DepartmentId",
                value: 0);
        }
    }
}
