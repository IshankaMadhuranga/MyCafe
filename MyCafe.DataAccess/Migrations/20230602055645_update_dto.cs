using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyCafe.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class update_dto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 26, 45, 9, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 26, 45, 9, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 26, 45, 9, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 26, 45, 9, DateTimeKind.Local).AddTicks(9103));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 17, 43, 692, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 17, 43, 692, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 17, 43, 692, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "StartDate",
                value: new DateTime(2023, 6, 2, 11, 17, 43, 692, DateTimeKind.Local).AddTicks(7219));
        }
    }
}
