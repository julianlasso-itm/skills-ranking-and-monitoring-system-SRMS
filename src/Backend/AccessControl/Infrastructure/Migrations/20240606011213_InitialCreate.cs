using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AccessControl.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    rol_role_id = table.Column<Guid>(type: "uuid", nullable: false),
                    rol_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    rol_description = table.Column<string>(type: "character varying(1024)", maxLength: 1024, nullable: true),
                    rol_disabled = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_role", x => x.rol_role_id);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    usr_user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    usr_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    usr_email = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    usr_password = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    usr_photo = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    usr_city_id = table.Column<Guid>(type: "uuid", nullable: false),
                    usr_disabled = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.usr_user_id);
                });

            migrationBuilder.CreateTable(
                name: "user_per_role",
                columns: table => new
                {
                    upr_id = table.Column<Guid>(type: "uuid", nullable: false),
                    upr_user_id = table.Column<Guid>(type: "uuid", nullable: false),
                    upr_role_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_per_role", x => x.upr_id);
                    table.ForeignKey(
                        name: "FK_user_per_role_role_upr_role_id",
                        column: x => x.upr_role_id,
                        principalTable: "role",
                        principalColumn: "rol_role_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_user_per_role_user_upr_user_id",
                        column: x => x.upr_user_id,
                        principalTable: "user",
                        principalColumn: "usr_user_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "rol_role_id", "created_at", "deleted_at", "rol_description", "rol_disabled", "rol_name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("137bcadf-79bb-47f4-8622-e7381c7664ae"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6795), null, "User role", false, "User", null },
                    { new Guid("1df5437f-e9e3-4513-bbe3-5314c0ff377f"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6819), null, "Author role", false, "Author", null },
                    { new Guid("20f1cc27-6209-473f-a859-976f4a29c2d4"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6823), null, "Contributor role", false, "Contributor", null },
                    { new Guid("33aed42e-7a15-4bc0-bdf0-cf36ae6aeb91"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6775), null, "Admin role", false, "Admin", null },
                    { new Guid("3d509fab-78f3-478e-886b-7e186dda6b8a"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6828), null, "Subscriber role", false, "Subscriber", null },
                    { new Guid("4d5ae754-400d-4fd1-ba59-012a01236ef3"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6805), null, "SuperAdmin role", false, "SuperAdmin", null },
                    { new Guid("6163f52d-61a3-47bd-b4b2-f4c77ffda98f"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6815), null, "Editor role", false, "Editor", null },
                    { new Guid("65011f4d-a1b8-404e-85a0-669a1f877f81"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6837), null, "Customer role", false, "Customer", null },
                    { new Guid("67f32155-4dcd-4661-8351-f832ba54b911"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6800), null, "Guest role", false, "Guest", null },
                    { new Guid("70f58873-e57d-422e-9284-3d9bf5e6606c"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6849), null, "Tester role", false, "Tester", null },
                    { new Guid("7bb9ebb0-5b29-4a29-9d60-ebdb50905ec4"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6809), null, "Moderator role", false, "Moderator", null },
                    { new Guid("9d3a6c36-cef3-4308-a8d3-127a914996c3"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6841), null, "Client role", false, "Client", null },
                    { new Guid("a325a098-1540-46bc-9966-311be6654f03"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6833), null, "Member role", false, "Member", null },
                    { new Guid("d599de0a-fcef-4933-81e4-49712bc69b62"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6853), null, "Developer role", false, "Developer", null },
                    { new Guid("ea767216-d8f3-4fec-b0fb-4c00a4864cb3"), new DateTime(2024, 6, 6, 1, 12, 12, 908, DateTimeKind.Utc).AddTicks(6845), null, "Viewer role", false, "Viewer", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_role_rol_name_deleted_at",
                table: "role",
                columns: new[] { "rol_name", "deleted_at" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_usr_email_deleted_at",
                table: "user",
                columns: new[] { "usr_email", "deleted_at" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_usr_email_usr_password",
                table: "user",
                columns: new[] { "usr_email", "usr_password" });

            migrationBuilder.CreateIndex(
                name: "IX_user_per_role_upr_role_id",
                table: "user_per_role",
                column: "upr_role_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_per_role_upr_user_id_upr_role_id",
                table: "user_per_role",
                columns: new[] { "upr_user_id", "upr_role_id" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user_per_role");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
