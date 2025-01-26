using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace value_analysis_server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    type = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    justification = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    status = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    code = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    provider1 = table.Column<int>(type: "int", nullable: true),
                    provider2 = table.Column<int>(type: "int", nullable: true),
                    provider3 = table.Column<int>(type: "int", nullable: true),
                    provider4 = table.Column<int>(type: "int", nullable: true),
                    selectedProvider = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    created_at = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "code", "created_at", "description", "name", "provider1", "provider2", "provider3", "provider4", "quantity", "selectedProvider", "updated_at" },
                values: new object[,]
                {
                    { new Guid("2031301c-e1dc-4ac4-8433-ac4ee5beb342"), "001", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1154), "Especificação / Descrição do produto genérico 1", "Product 1", 100, 100, 100, 100, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1249) },
                    { new Guid("4b28aa95-eaa0-4e3f-9fe0-8b8c8380cd50"), "008", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1355), "Especificação / Descrição do produto genérico 8", "Product 8", null, null, null, null, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1356) },
                    { new Guid("8fb81fa6-0daf-4e3f-8b8a-82f2c69930bc"), "002", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1329), "Especificação / Descrição do produto genérico 2", "Product 2", 100, 100, 100, 100, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1330) },
                    { new Guid("a55ffbaa-9188-4bc6-86d4-d82464c79170"), "004", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1336), "Especificação / Descrição do produto genérico 4", "Product 4", 100, 100, 100, 100, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1337) },
                    { new Guid("ac2d96f9-afe9-4fa8-b962-9969b09e9d7f"), "005", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1339), "Especificação / Descrição do produto genérico 5", "Product 5", null, null, null, null, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1339) },
                    { new Guid("adfde6a5-c35f-4204-b730-7de18bde1b30"), "010", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1360), "Especificação / Descrição do produto genérico 10", "Product 10", null, null, null, null, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1361) },
                    { new Guid("b08d2b45-8f69-4312-9335-ff01b2cf80f4"), "007", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1353), "Especificação / Descrição do produto genérico 7", "Product 7", null, null, null, null, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1353) },
                    { new Guid("b245d408-dfbd-46d4-b2e2-0cd43357b85d"), "009", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1358), "Especificação / Descrição do produto genérico 9", "Product 9", null, null, null, null, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1358) },
                    { new Guid("d27386cf-3769-46a6-864a-4229b668bc81"), "006", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1350), "Especificação / Descrição do produto genérico 6", "Product 6", null, null, null, null, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1350) },
                    { new Guid("dc035e4d-f889-4961-aa2f-4df046fd6831"), "003", new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1333), "Especificação / Descrição do produto genérico 3", "Product 3", 100, 100, 100, 100, 100, null, new DateTime(2025, 1, 26, 14, 7, 37, 331, DateTimeKind.Local).AddTicks(1334) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
