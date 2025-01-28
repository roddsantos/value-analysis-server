using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace value_analysis_server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrations : Migration
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
                    quantity = table.Column<float>(type: "float", nullable: false),
                    provider1 = table.Column<float>(type: "float", nullable: true),
                    provider2 = table.Column<float>(type: "float", nullable: true),
                    provider3 = table.Column<float>(type: "float", nullable: true),
                    provider4 = table.Column<float>(type: "float", nullable: true),
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
                    { new Guid("24c641c8-fa3b-45fa-bc9f-2bb64262d29c"), "007", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3686), "Especificação / Descrição do produto genérico 7", "Product 7", null, null, null, null, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3686) },
                    { new Guid("25f13797-5a4e-47f9-89ae-082090d7a665"), "005", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3674), "Especificação / Descrição do produto genérico 5", "Product 5", null, null, null, null, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3674) },
                    { new Guid("3286c127-dd88-4301-a82a-dfbe40c5c98a"), "008", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3688), "Especificação / Descrição do produto genérico 8", "Product 8", null, null, null, null, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3689) },
                    { new Guid("358537b8-6340-47d5-bb0e-2572e850eced"), "006", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3676), "Especificação / Descrição do produto genérico 6", "Product 6", null, null, null, null, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3676) },
                    { new Guid("40ce3dbe-8490-4174-96a5-0b9526c22c33"), "002", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3663), "Especificação / Descrição do produto genérico 2", "Product 2", 100f, 100f, 100f, 100f, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3664) },
                    { new Guid("8bf1c81b-1d2c-4d0c-9ded-08e0cbb92e78"), "004", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3671), "Especificação / Descrição do produto genérico 4", "Product 4", 100f, 100f, 100f, 100f, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3671) },
                    { new Guid("8d4aa177-dcca-415d-ad4e-20a3b6478ae3"), "010", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3694), "Especificação / Descrição do produto genérico 10", "Product 10", null, null, null, null, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3694) },
                    { new Guid("9b74b628-a3b5-4fad-9335-5c0fbe25ee3c"), "009", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3691), "Especificação / Descrição do produto genérico 9", "Product 9", null, null, null, null, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3691) },
                    { new Guid("9bf5b1a2-b749-4012-b7df-63fa67c675c1"), "003", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3667), "Especificação / Descrição do produto genérico 3", "Product 3", 100f, 100f, 100f, 100f, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3668) },
                    { new Guid("f3c4cda2-f5ab-46f3-9b9e-a83939c6a4bb"), "001", new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3499), "Especificação / Descrição do produto genérico 1", "Product 1", 100f, 100f, 100f, 100f, 100f, null, new DateTime(2025, 1, 27, 21, 16, 11, 763, DateTimeKind.Local).AddTicks(3585) }
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
