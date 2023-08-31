using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class addUsersTableToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Role = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 33, 38, 494, DateTimeKind.Local).AddTicks(9543), "https://dotnetmastery.com/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 33, 38, 494, DateTimeKind.Local).AddTicks(9553), "https://dotnetmastery.com/bluevillaimages/villa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 33, 38, 494, DateTimeKind.Local).AddTicks(9554), "https://dotnetmastery.com/bluevillaimages/villa4.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 33, 38, 494, DateTimeKind.Local).AddTicks(9556), "https://dotnetmastery.com/bluevillaimages/villa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 31, 14, 33, 38, 494, DateTimeKind.Local).AddTicks(9557), "https://dotnetmastery.com/bluevillaimages/villa2.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 25, 13, 36, 7, 805, DateTimeKind.Local).AddTicks(5379), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa3.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 25, 13, 36, 7, 805, DateTimeKind.Local).AddTicks(5390), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa1.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 25, 13, 36, 7, 805, DateTimeKind.Local).AddTicks(5391), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa4.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 25, 13, 36, 7, 805, DateTimeKind.Local).AddTicks(5393), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa5.jpg" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2023, 8, 25, 13, 36, 7, 805, DateTimeKind.Local).AddTicks(5394), "https://dotnetmasteryimages.blob.core.windows.net/bluevillaimages/villa2.jpg" });
        }
    }
}
