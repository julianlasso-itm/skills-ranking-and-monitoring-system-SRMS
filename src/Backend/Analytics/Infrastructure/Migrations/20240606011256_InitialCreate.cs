using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Analytics.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "level",
                columns: table => new
                {
                    rol_level_id = table.Column<Guid>(type: "uuid", nullable: false),
                    rol_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    rol_description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    rol_disabled = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_level", x => x.rol_level_id);
                });

            migrationBuilder.InsertData(
                table: "level",
                columns: new[] { "rol_level_id", "created_at", "deleted_at", "rol_description", "rol_disabled", "rol_name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("028de8ac-4c8f-4a94-aa66-a844e42d12cc"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3737), null, null, false, "DataScience", null },
                    { new Guid("155eecee-87b0-46fc-aa04-bf1404406770"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3716), null, null, false, "Frontend", null },
                    { new Guid("2fc96373-291c-4d14-9c39-c31c98661cd1"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3708), null, null, false, "Backend", null },
                    { new Guid("3d9ccb29-7a60-4ac1-aae2-9228e2ce9715"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3755), null, null, false, "Management", null },
                    { new Guid("5e55880c-6971-4d37-b8dd-47b198849807"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3741), null, null, false, "Cybersecurity", null },
                    { new Guid("6677c7e6-5e60-4146-93bb-a6d86d28b67b"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3751), null, null, false, "Project", null },
                    { new Guid("71ca0bc8-52f7-42e1-8541-88d8b71a5a19"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3759), null, null, false, "Other", null },
                    { new Guid("74746ada-4c24-4cc5-bf9c-e009e6dbc4ce"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3746), null, null, false, "Product", null },
                    { new Guid("a143be47-5cf2-41dc-9072-2f7cb1a66bd5"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3724), null, null, false, "DevOps", null },
                    { new Guid("b2b3c42b-b2a5-4086-8eff-7cc483bb40b9"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3734), null, null, false, "UX/UI", null },
                    { new Guid("b3d342d9-8c40-45f5-bb7f-9a51fd20a87b"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3728), null, null, false, "QA", null },
                    { new Guid("bb020e08-19d8-406d-a71d-ec8a2fdb15b7"), new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3721), null, null, false, "Fullstack", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_level_rol_name",
                table: "level",
                column: "rol_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "level");
        }
    }
}
