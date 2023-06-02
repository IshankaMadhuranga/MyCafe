using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCafe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 42, 3, 574, DateTimeKind.Local).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 42, 3, 574, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 42, 3, 574, DateTimeKind.Local).AddTicks(5288));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 42, 3, 574, DateTimeKind.Local).AddTicks(5289));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 28, 11, 310, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 28, 11, 310, DateTimeKind.Local).AddTicks(3901));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 28, 11, 310, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2023, 6, 1, 22, 28, 11, 310, DateTimeKind.Local).AddTicks(3902));
        }
    }
}
