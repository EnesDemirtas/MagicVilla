using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddLocalImagePathForVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageLocalPath",
                table: "Villas",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageLocalPath" },
                values: new object[] { new DateTime(2023, 9, 3, 19, 7, 43, 623, DateTimeKind.Local).AddTicks(5492), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageLocalPath" },
                values: new object[] { new DateTime(2023, 9, 3, 19, 7, 43, 623, DateTimeKind.Local).AddTicks(5506), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageLocalPath" },
                values: new object[] { new DateTime(2023, 9, 3, 19, 7, 43, 623, DateTimeKind.Local).AddTicks(5509), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageLocalPath" },
                values: new object[] { new DateTime(2023, 9, 3, 19, 7, 43, 623, DateTimeKind.Local).AddTicks(5511), null });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageLocalPath" },
                values: new object[] { new DateTime(2023, 9, 3, 19, 7, 43, 623, DateTimeKind.Local).AddTicks(5514), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageLocalPath",
                table: "Villas");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 15, 58, 12, 181, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 15, 58, 12, 181, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 15, 58, 12, 181, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 15, 58, 12, 181, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2023, 9, 2, 15, 58, 12, 181, DateTimeKind.Local).AddTicks(2929));
        }
    }
}
