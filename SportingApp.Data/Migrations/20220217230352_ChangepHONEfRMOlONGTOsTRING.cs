using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportingApp.Data.Migrations
{
    public partial class ChangepHONEfRMOlONGTOsTRING : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Technicians",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Phone",
                value: "3315681100");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Phone",
                value: "3325233100");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 17, 23, 3, 44, 906, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 17, 23, 3, 44, 906, DateTimeKind.Utc).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 17, 23, 3, 44, 905, DateTimeKind.Utc).AddTicks(9781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 17, 23, 3, 44, 905, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Phone",
                value: "3315681100");

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Phone",
                value: "3125337157");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Phone",
                table: "Technicians",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<long>(
                name: "Phone",
                table: "Customers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Phone",
                value: 3315681100L);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Phone",
                value: 3325233100L);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 17, 17, 51, 3, 476, DateTimeKind.Utc).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 17, 17, 51, 3, 476, DateTimeKind.Utc).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 17, 17, 51, 3, 476, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 17, 17, 51, 3, 476, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "Id",
                keyValue: 1L,
                column: "Phone",
                value: 3315681100L);

            migrationBuilder.UpdateData(
                table: "Technicians",
                keyColumn: "Id",
                keyValue: 2L,
                column: "Phone",
                value: 3125337157L);
        }
    }
}
