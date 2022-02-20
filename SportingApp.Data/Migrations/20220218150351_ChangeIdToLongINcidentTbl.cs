using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportingApp.Data.Migrations
{
    public partial class ChangeIdToLongINcidentTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Customers_CustomerId1",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Products_ProductId1",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId1",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_CustomerId1",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_ProductId1",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_TechnicianId1",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Incidents");

            migrationBuilder.DropColumn(
                name: "TechnicianId1",
                table: "Incidents");

            migrationBuilder.AlterColumn<long>(
                name: "TechnicianId",
                table: "Incidents",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "Incidents",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Incidents",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CustomerId", "DateOpened", "ProductId", "TechnicianId" },
                values: new object[] { 1L, new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1964), 1L, 1L });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CustomerId", "DateOpened", "ProductId", "TechnicianId" },
                values: new object[] { 2L, new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1967), 2L, 2L });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 18, 15, 3, 50, 841, DateTimeKind.Utc).AddTicks(1694));

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerId",
                table: "Incidents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductId",
                table: "Incidents",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechnicianId",
                table: "Incidents",
                column: "TechnicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Customers_CustomerId",
                table: "Incidents",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Products_ProductId",
                table: "Incidents",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Customers_CustomerId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Products_ProductId",
                table: "Incidents");

            migrationBuilder.DropForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_CustomerId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_ProductId",
                table: "Incidents");

            migrationBuilder.DropIndex(
                name: "IX_Incidents_TechnicianId",
                table: "Incidents");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Incidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Incidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Incidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId1",
                table: "Incidents",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId1",
                table: "Incidents",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "TechnicianId1",
                table: "Incidents",
                type: "bigint",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CustomerId", "DateOpened", "ProductId", "TechnicianId" },
                values: new object[] { 1, new DateTime(2022, 2, 17, 23, 3, 44, 906, DateTimeKind.Utc).AddTicks(265), 1, 1 });

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CustomerId", "DateOpened", "ProductId", "TechnicianId" },
                values: new object[] { 2, new DateTime(2022, 2, 17, 23, 3, 44, 906, DateTimeKind.Utc).AddTicks(269), 2, 2 });

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

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerId1",
                table: "Incidents",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductId1",
                table: "Incidents",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechnicianId1",
                table: "Incidents",
                column: "TechnicianId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Customers_CustomerId1",
                table: "Incidents",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Products_ProductId1",
                table: "Incidents",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Incidents_Technicians_TechnicianId1",
                table: "Incidents",
                column: "TechnicianId1",
                principalTable: "Technicians",
                principalColumn: "Id");
        }
    }
}
