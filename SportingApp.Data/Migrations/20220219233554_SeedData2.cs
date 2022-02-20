using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportingApp.Data.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 19, 23, 35, 53, 898, DateTimeKind.Utc).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 19, 23, 35, 53, 898, DateTimeKind.Utc).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 19, 23, 35, 53, 898, DateTimeKind.Utc).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 19, 23, 35, 53, 898, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "RoleId" },
                values: new object[] { 1, "abc@abc.com", "TestUser", "ABC", "abcdef", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 19, 23, 13, 39, 571, DateTimeKind.Utc).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 19, 23, 13, 39, 571, DateTimeKind.Utc).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 19, 23, 13, 39, 571, DateTimeKind.Utc).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 19, 23, 13, 39, 571, DateTimeKind.Utc).AddTicks(858));
        }
    }
}
