using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportingApp.Data.Migrations
{
    public partial class SeedRegistrationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Customers_CustomerId1",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Products_ProductId1",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_CustomerId1",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_ProductId1",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Registrations");

            migrationBuilder.AlterColumn<long>(
                name: "ProductId",
                table: "Registrations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "CustomerId",
                table: "Registrations",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 20, 11, 52, 24, 414, DateTimeKind.Utc).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Incidents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateOpened",
                value: new DateTime(2022, 2, 20, 11, 52, 24, 414, DateTimeKind.Utc).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 20, 11, 52, 24, 414, DateTimeKind.Utc).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                column: "ReleaseDate",
                value: new DateTime(2022, 2, 20, 11, 52, 24, 414, DateTimeKind.Utc).AddTicks(3809));

            migrationBuilder.InsertData(
                table: "Registrations",
                columns: new[] { "Id", "CustomerId", "ProductId" },
                values: new object[,]
                {
                    { 1L, 1L, 1L },
                    { 2L, 2L, 2L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CustomerId",
                table: "Registrations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ProductId",
                table: "Registrations",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Customers_CustomerId",
                table: "Registrations",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Products_ProductId",
                table: "Registrations",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Customers_CustomerId",
                table: "Registrations");

            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Products_ProductId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_CustomerId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_ProductId",
                table: "Registrations");

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Registrations",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "Registrations",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Registrations",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "CustomerId1",
                table: "Registrations",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ProductId1",
                table: "Registrations",
                type: "bigint",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_CustomerId1",
                table: "Registrations",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_ProductId1",
                table: "Registrations",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Customers_CustomerId1",
                table: "Registrations",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Products_ProductId1",
                table: "Registrations",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
