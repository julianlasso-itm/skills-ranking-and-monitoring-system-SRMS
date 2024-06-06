using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Profiles.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    ctr_country_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ctr_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ctr_disabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.ctr_country_id);
                });

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

            migrationBuilder.CreateTable(
                name: "professional",
                columns: table => new
                {
                    prf_professional_id = table.Column<Guid>(type: "uuid", nullable: false),
                    prf_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    prf_email = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    prf_disabled = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_professional", x => x.prf_professional_id);
                });

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
                name: "skill",
                columns: table => new
                {
                    skl_skill_id = table.Column<Guid>(type: "uuid", nullable: false),
                    skl_name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    skl_disabled = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    deleted_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.skl_skill_id);
                });

            migrationBuilder.CreateTable(
                name: "province",
                columns: table => new
                {
                    prv_province_id = table.Column<Guid>(type: "uuid", nullable: false),
                    ctr_country_id = table.Column<Guid>(type: "uuid", nullable: false),
                    prv_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    prv_disabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_province", x => x.prv_province_id);
                    table.ForeignKey(
                        name: "FK_province_country_ctr_country_id",
                        column: x => x.ctr_country_id,
                        principalTable: "country",
                        principalColumn: "ctr_country_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    cty_city_id = table.Column<Guid>(type: "uuid", nullable: false),
                    prv_province_id = table.Column<Guid>(type: "uuid", nullable: false),
                    cty_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    cty_disabled = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.cty_city_id);
                    table.ForeignKey(
                        name: "FK_city_province_prv_province_id",
                        column: x => x.prv_province_id,
                        principalTable: "province",
                        principalColumn: "prv_province_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "country",
                columns: new[] { "ctr_country_id", "ctr_disabled", "ctr_name" },
                values: new object[,]
                {
                    { new Guid("1a002345-c49e-4057-aff9-052fb936db36"), false, "Paraguay" },
                    { new Guid("21a134df-0b33-4098-be50-bef01f0916fa"), false, "Bolivia" },
                    { new Guid("4b1fc2c0-ddc8-4552-918e-137e09894c88"), false, "Honduras" },
                    { new Guid("4ff85abd-6bb3-4122-b5c8-e06848957c8e"), false, "México" },
                    { new Guid("5a63237b-d0e6-4603-89d1-656f7f0d8a3b"), false, "Venezuela" },
                    { new Guid("63570461-5f95-40ba-b205-88ebbb14529c"), false, "Costa Rica" },
                    { new Guid("68e44283-9fc2-4b82-a6e8-80877c164b0f"), false, "Nicaragua" },
                    { new Guid("7997a384-5a0b-4968-be42-c8466cc286b0"), false, "Brasil" },
                    { new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Ecuador" },
                    { new Guid("81dacc73-8484-4519-bf6d-a9c0b5503901"), false, "Chile" },
                    { new Guid("925d036e-8958-44be-9b38-05a0eb0f3bd0"), false, "Panamá" },
                    { new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Colombia" },
                    { new Guid("a442ffb9-7dee-4c16-b2c0-1de534afec93"), false, "Uruguay" },
                    { new Guid("ce60c6f2-c39e-4d77-a91c-8700d327467d"), false, "Argentina" },
                    { new Guid("df9218c6-6071-4583-a482-6c2f69c76926"), false, "Perú" },
                    { new Guid("f96128d0-a6d2-4638-81a7-0b1053dde626"), false, "El Salvador" },
                    { new Guid("f9fcf0d6-0364-4782-9c06-7300cdaef975"), false, "Guatemala" },
                    { new Guid("fe84b3d9-2b31-4186-96e8-f40776825324"), false, "Belize" }
                });

            migrationBuilder.InsertData(
                table: "professional",
                columns: new[] { "prf_professional_id", "created_at", "deleted_at", "prf_disabled", "prf_email", "prf_name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("23c84402-a063-4f14-ad92-ca511fbf4147"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7858), null, false, "isabelmartinez@gmail.com", "Isabel Martínez", null },
                    { new Guid("56d59143-01ba-475c-9fd3-d153bc1d73ca"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7820), null, false, "mariagarcia@gmail.com", "María García", null },
                    { new Guid("66fd5605-0c9b-4328-8b63-cfb9ecf2144b"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7882), null, false, "patriciablanco@gmail.com", "Patricia Blanco", null },
                    { new Guid("7476282c-383a-466c-9cc6-4188ac3af9b0"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7893), null, false, "luisvazquez@gmail.com", "Luis Vázquez", null },
                    { new Guid("7ca4d0a7-3578-4648-b797-8e8520435cac"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7853), null, false, "carlosrodriguez@gmail.com", "Carlos Rodríguez", null },
                    { new Guid("85788fc7-5ebc-429c-b8b0-da32eb473fba"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7874), null, false, "lauragonzalez@gmail.com", "Laura González", null },
                    { new Guid("a0c61d04-be3e-46f7-b702-be78a388f238"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7812), null, false, "juanperez@gmail.com", "Juan Pérez", null },
                    { new Guid("a5c0c24d-0077-4955-96c2-9e8562599eef"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7866), null, false, "sandramoreno@gmail.com", "Sandra Moreno", null },
                    { new Guid("b328688b-1c96-46c4-b743-731e90be5c54"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7878), null, false, "javiermunoz@gmail.com", "Javier Muñoz", null },
                    { new Guid("b959aa21-f0f9-4da0-81f9-32857f6324d9"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7889), null, false, "aliciaruis@gmail.com", "Alicia Ruiz", null },
                    { new Guid("bcd93c44-a805-4c99-9fd5-4d2a3ed282c4"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7862), null, false, "diegogomez@gmail.com", "Diego Gómez", null },
                    { new Guid("bdc99ecc-5987-44c0-a40e-5131381d0484"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7886), null, false, "josegutierrez@gmail.com", "José Gutiérrez", null },
                    { new Guid("d4d82078-b9b9-4454-a526-1feff8efb456"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7845), null, false, "pedrolopez@gmail.com", "Pedro López", null },
                    { new Guid("d81f48f7-eff9-4d66-96a6-127c33a71c1d"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7849), null, false, "anasanchez@gmail.com", "Ana Sánchez", null },
                    { new Guid("e7f23c52-0ddc-47df-b8cc-65d3bf619d8e"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7869), null, false, "andresfernandez@gmail.com", "Andrés Fernández", null }
                });

            migrationBuilder.InsertData(
                table: "role",
                columns: new[] { "rol_role_id", "created_at", "deleted_at", "rol_description", "rol_disabled", "rol_name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("08e844c8-d7ba-46bd-b8e5-f4593ad4c14e"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7670), null, null, false, "QA", null },
                    { new Guid("0f38e6c7-adf9-4a75-9a33-eba0655ab26a"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7701), null, null, false, "Lead Designer", null },
                    { new Guid("17f63ad7-4c5a-4f2a-9210-f7b198f6c838"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7690), null, null, false, "Scrum Master", null },
                    { new Guid("45142aa4-0a8e-4f15-af46-03c5a1f643a1"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7679), null, null, false, "Data Scientist", null },
                    { new Guid("57a39ac1-e148-4ce7-afa1-0ba5a3b2593b"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7674), null, null, false, "DevOps", null },
                    { new Guid("72f25a1b-25c0-402f-a607-3c96f3ed90b3"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7666), null, null, false, "Manager", null },
                    { new Guid("784fe2b3-29e4-4330-8397-739962ad70d3"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7686), null, null, false, "Product Owner", null },
                    { new Guid("b4793973-453a-41cf-bb1c-630f67deabfb"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7682), null, null, false, "UX/UI Designer", null },
                    { new Guid("b5000d60-90c7-433f-a9bb-a91d4ac7c733"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7656), null, null, false, "Developer", null },
                    { new Guid("d253068f-843a-4ad7-b5a6-035e83c065bc"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7662), null, null, false, "Designer", null },
                    { new Guid("d665c05b-62a1-40da-a598-68367f437da3"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7694), null, null, false, "Architect", null },
                    { new Guid("f6c8e0ad-918e-4f90-95d1-8ac5542b0426"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7698), null, null, false, "Lead Developer", null }
                });

            migrationBuilder.InsertData(
                table: "skill",
                columns: new[] { "skl_skill_id", "created_at", "deleted_at", "skl_disabled", "skl_name", "updated_at" },
                values: new object[,]
                {
                    { new Guid("0bfa4de1-3408-41b4-89e5-6d3fc48760e0"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7768), null, false, "Vue", null },
                    { new Guid("4d710637-5854-4575-ad1d-1977c3ffd88d"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7771), null, false, "Node.js", null },
                    { new Guid("50e2b8f4-3e30-4574-80fb-cb8d6771ad06"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7746), null, false, "HTML", null },
                    { new Guid("5c4b817a-21cc-46b6-971f-56e544239fcd"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7753), null, false, "SQL", null },
                    { new Guid("5d5e77c5-81e4-47e3-8f63-1bc5c0db6461"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7730), null, false, "Java", null },
                    { new Guid("7be23de2-ae7d-4173-a887-4ef0001cab6e"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7734), null, false, "Python", null },
                    { new Guid("8a874dc5-ee4a-4b4a-b2b0-4e28e586ecbb"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7767), null, false, "React", null },
                    { new Guid("9fa76d5b-38b4-4ad3-8828-384506e3f7db"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7724), null, false, "C#", null },
                    { new Guid("a618e994-345c-45eb-8f26-7bdccc78c8f3"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7760), null, false, "Angular", null },
                    { new Guid("a89f8793-46ab-44e2-afde-27afa29ed80a"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7778), null, false, "Hibernate", null },
                    { new Guid("aff33eea-30e8-4159-88e2-b868b7cb62ab"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7741), null, false, "TypeScript", null },
                    { new Guid("bfa749e8-3330-453a-9060-524b3656fc81"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7749), null, false, "CSS", null },
                    { new Guid("c03ffed4-5c3f-493c-8432-dbb33cfba677"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7756), null, false, "NoSQL", null },
                    { new Guid("cd3fba82-8b2d-46e4-be20-9352172cdfb8"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7738), null, false, "JavaScript", null },
                    { new Guid("fe5fc9b7-da0c-475b-bfc6-cf27c8dea48b"), new DateTime(2024, 6, 6, 1, 14, 6, 432, DateTimeKind.Utc).AddTicks(7775), null, false, "Spring Boot", null }
                });

            migrationBuilder.InsertData(
                table: "province",
                columns: new[] { "prv_province_id", "ctr_country_id", "prv_disabled", "prv_name" },
                values: new object[,]
                {
                    { new Guid("0142d0da-56e2-4a6a-8d19-c1447fd88e45"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Galápagos" },
                    { new Guid("02baec1c-81e0-4f0e-90a1-9107d469777c"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Caquetá" },
                    { new Guid("02fdcc0c-4ccb-4385-8443-b423f044555c"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Norte de Santander" },
                    { new Guid("0613864e-c378-4e2e-813f-35da9a9745b2"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Carchi" },
                    { new Guid("0adc5d72-3b8f-40d6-a55b-039bf971ab21"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Cauca" },
                    { new Guid("12408d66-333b-4495-8a5c-b82f577d6483"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Chimborazo" },
                    { new Guid("16f922a3-4c19-432c-a822-415a40f6c13a"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Magdalena" },
                    { new Guid("20d9774c-9e67-434a-8db9-21e14b7aef47"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Córdoba" },
                    { new Guid("22ee9fff-0a8c-4600-bb17-7eeeff6a2a99"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Morona Santiago" },
                    { new Guid("2624291f-182d-4183-84f4-5eaf4fdc2db6"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Arauca" },
                    { new Guid("29b67093-6129-4ee5-8255-5ba86b1bf59d"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Manabí" },
                    { new Guid("2b0a16b1-5a5c-4520-a885-837980b73ec9"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "La Guajira" },
                    { new Guid("3accd102-139e-4b54-a266-dba40c5a1d77"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Santander" },
                    { new Guid("3bc8bea0-0772-4466-a1e0-8bf22bf3f2c2"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Risaralda" },
                    { new Guid("3d155301-298f-4294-b9ae-f99f2750ade9"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Imbabura" },
                    { new Guid("471dc235-a393-46d6-9dac-e68fded03e44"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "El Oro" },
                    { new Guid("47c6c58c-31aa-40c4-946c-bb206bbf893b"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Bolívar" },
                    { new Guid("55bb69fb-01a2-41b0-aa1d-6bb3e3828e46"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Meta" },
                    { new Guid("5a03edca-c978-46ff-94c1-d90fab048198"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Guayas" },
                    { new Guid("5ce551fe-655e-49a7-95ad-e113f65b0e6f"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Bolívar" },
                    { new Guid("5dd698b1-29ba-4728-a324-f64deda85fc9"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Quindío" },
                    { new Guid("60991494-70c3-4a03-9ef1-1d1d97429c42"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Caldas" },
                    { new Guid("6142179e-b85a-445b-b192-13c55e0fde7a"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Amazonas" },
                    { new Guid("62761b57-94ac-49f8-ac2e-a68b54f0985a"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Atlántico" },
                    { new Guid("674ddb31-9a94-45a1-893b-d88d9c6837d6"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Napo" },
                    { new Guid("6ce4ee7c-57ee-456d-a90b-1ff3c9ffc62a"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Nariño" },
                    { new Guid("6d184776-b4b5-43e8-972a-0281f7d3cb15"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Vichada" },
                    { new Guid("714d1455-c57c-4686-9b34-18b663d93d38"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Valle del Cauca" },
                    { new Guid("75ad794e-0be4-4cf9-8bd3-162426433a1f"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Guainía" },
                    { new Guid("7816b4fa-f3da-4672-94c3-b827c1e04070"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Guaviare" },
                    { new Guid("7edc4b28-27d9-404e-9d41-eb112e72b2e3"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Putumayo" },
                    { new Guid("7faa43bf-7415-4097-8f56-aa900c2fe772"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Tolima" },
                    { new Guid("885f08a2-3c01-47bd-8362-11e75024e207"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Chocó" },
                    { new Guid("8a92bf7a-8302-4e80-871d-fbd4340c9b81"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Loja" },
                    { new Guid("99cd5f3c-b591-4a1a-8574-c5b82ea0d337"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "San Andrés y Providencia" },
                    { new Guid("9e19aff9-071a-4173-9f03-188d08d8a269"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Azuay" },
                    { new Guid("a437622c-a366-470c-a8c1-6e57ca71689a"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Cotopaxi" },
                    { new Guid("b667da90-18aa-4332-bfcc-98180817039f"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Antioquia" },
                    { new Guid("bd57297e-b985-4190-ae3a-2a04ba486325"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Boyacá" },
                    { new Guid("c6da6aa6-0d49-449d-8487-b940f4ce1648"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Sucre" },
                    { new Guid("cc406ecc-7147-4f55-8096-46016755d3d6"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Casanare" },
                    { new Guid("ccddf62c-d27e-4d6a-97a8-2b24bcf763cb"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Esmeraldas" },
                    { new Guid("dcf423b2-e93d-41fc-bc0a-8669ee52230d"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Cesar" },
                    { new Guid("e1683fb9-da94-4b64-9402-541b2a65b5bd"), new Guid("7c6ca238-8b60-4a1e-a1b2-a2d381069cf4"), false, "Cañar" },
                    { new Guid("ef552fa0-def3-4c9f-87a9-5b914387b7d5"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Cundinamarca" },
                    { new Guid("f17a7d74-8a10-49b3-92d9-14f21cc6dd24"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Vaupés" },
                    { new Guid("f1df1f3f-5616-444d-9bff-9ff1b94a0c56"), new Guid("951a7fd8-230c-4d8a-a68a-b20aec5f4e95"), false, "Huila" }
                });

            migrationBuilder.InsertData(
                table: "city",
                columns: new[] { "cty_city_id", "cty_disabled", "cty_name", "prv_province_id" },
                values: new object[,]
                {
                    { new Guid("0075ed9a-5e38-4227-a075-a84ce7bc4f7b"), false, "Morelia", new Guid("02baec1c-81e0-4f0e-90a1-9107d469777c") },
                    { new Guid("0406e2e7-b2a6-4fcd-a077-9f871effa12f"), false, "Apartadó", new Guid("b667da90-18aa-4332-bfcc-98180817039f") },
                    { new Guid("0741b7e4-a898-4f39-8a8b-165d6c4ddfa0"), false, "Quibdó", new Guid("885f08a2-3c01-47bd-8362-11e75024e207") },
                    { new Guid("08245541-7669-4ae8-959f-aa9445565b26"), false, "Istmina", new Guid("885f08a2-3c01-47bd-8362-11e75024e207") },
                    { new Guid("08a4b71e-5001-457e-ada2-56d81f267c27"), false, "Barrancabermeja", new Guid("3accd102-139e-4b54-a266-dba40c5a1d77") },
                    { new Guid("0a300b00-6aca-4316-ad69-68393706d26e"), false, "Duitama", new Guid("bd57297e-b985-4190-ae3a-2a04ba486325") },
                    { new Guid("0afe0ce5-5cb2-4568-ae6a-a19dc1600980"), false, "San Miguel de Bolívar", new Guid("47c6c58c-31aa-40c4-946c-bb206bbf893b") },
                    { new Guid("0b363116-0d32-4b71-b9af-89ed3b36a4fe"), false, "Yavaraté", new Guid("f17a7d74-8a10-49b3-92d9-14f21cc6dd24") },
                    { new Guid("0c65fd0c-ad28-4661-9f70-0b7006ae9e60"), false, "Tulcán", new Guid("0613864e-c378-4e2e-813f-35da9a9745b2") },
                    { new Guid("0c8cd540-e02b-4137-b688-e019dea27870"), false, "Neiva", new Guid("f1df1f3f-5616-444d-9bff-9ff1b94a0c56") },
                    { new Guid("0cf3ee89-11af-4f00-a081-e875bcd88d97"), false, "San Juan de Pasto", new Guid("6ce4ee7c-57ee-456d-a90b-1ff3c9ffc62a") },
                    { new Guid("0e1131bb-4f37-4761-b39c-9570327e6ace"), false, "Armero Guayabal", new Guid("7faa43bf-7415-4097-8f56-aa900c2fe772") },
                    { new Guid("0f99d66c-0918-4ed0-b079-7c59c53ef816"), false, "Atacames", new Guid("ccddf62c-d27e-4d6a-97a8-2b24bcf763cb") },
                    { new Guid("10a18e71-d50b-4cc9-aea9-4ee1d05bae21"), false, "Esmeraldas", new Guid("ccddf62c-d27e-4d6a-97a8-2b24bcf763cb") },
                    { new Guid("1899aec0-2b3d-43f0-bf3e-a6ed03160c5b"), false, "Maicao", new Guid("2b0a16b1-5a5c-4520-a885-837980b73ec9") },
                    { new Guid("18ad6719-f234-4de3-8c09-160af8916d06"), false, "Montería", new Guid("c6da6aa6-0d49-449d-8487-b940f4ce1648") },
                    { new Guid("1dd1625b-f0ad-4cba-b02e-d18cc24dbd9e"), false, "Pitalito", new Guid("f1df1f3f-5616-444d-9bff-9ff1b94a0c56") },
                    { new Guid("21bb6731-0377-404d-9898-928657e6074f"), false, "Ipiales", new Guid("6ce4ee7c-57ee-456d-a90b-1ff3c9ffc62a") },
                    { new Guid("267ae103-7fb4-40e0-be1c-2e9e148a7fb5"), false, "Ciénaga", new Guid("16f922a3-4c19-432c-a822-415a40f6c13a") },
                    { new Guid("2e5e2e50-60b0-4eca-812e-36c0a8d93bf7"), false, "Ibagué", new Guid("7faa43bf-7415-4097-8f56-aa900c2fe772") },
                    { new Guid("303e5bad-6d33-4ed5-9e7b-cecf537dcbab"), false, "San José del Guaviare", new Guid("7816b4fa-f3da-4672-94c3-b827c1e04070") },
                    { new Guid("31b3ec71-b68f-4e9e-8c82-43f5cdc438d6"), false, "Puerto Colombia", new Guid("62761b57-94ac-49f8-ac2e-a68b54f0985a") },
                    { new Guid("35fe0b03-0d6c-416d-ac12-c7c37e34f829"), false, "Riobamba", new Guid("12408d66-333b-4495-8a5c-b82f577d6483") },
                    { new Guid("3b31f60f-dfb6-4e82-bbf0-776f6ce9a771"), false, "Armenia", new Guid("5dd698b1-29ba-4728-a324-f64deda85fc9") },
                    { new Guid("423cd6b4-38ca-455f-9c1b-de8a1c1117d6"), false, "Santa Marta", new Guid("16f922a3-4c19-432c-a822-415a40f6c13a") },
                    { new Guid("482c7897-f05c-4193-8a71-fff6cba454ca"), false, "Cartagena del Chairá", new Guid("5ce551fe-655e-49a7-95ad-e113f65b0e6f") },
                    { new Guid("48542efb-77ba-4a28-9928-b3bd8963a97e"), false, "Acacias", new Guid("55bb69fb-01a2-41b0-aa1d-6bb3e3828e46") },
                    { new Guid("48d86fc7-ab2c-4f16-92e7-305b8af4041c"), false, "Guaranda", new Guid("47c6c58c-31aa-40c4-946c-bb206bbf893b") },
                    { new Guid("4bd497a1-7d0e-4d66-8377-b337e52cd246"), false, "San Cristóbal", new Guid("0142d0da-56e2-4a6a-8d19-c1447fd88e45") },
                    { new Guid("4d10b530-ee6d-4a2c-a0a5-2feed79f9274"), false, "Riohacha", new Guid("2b0a16b1-5a5c-4520-a885-837980b73ec9") },
                    { new Guid("4ef78282-aa9d-4ddf-b246-05e633c0e9a5"), false, "Corozal", new Guid("c6da6aa6-0d49-449d-8487-b940f4ce1648") },
                    { new Guid("500f6857-0063-44d2-9154-fac9b796c949"), false, "Turbo", new Guid("b667da90-18aa-4332-bfcc-98180817039f") },
                    { new Guid("503d6aa5-033e-4128-81b2-c03e499cb6a0"), false, "Sogamoso", new Guid("bd57297e-b985-4190-ae3a-2a04ba486325") },
                    { new Guid("53cfa130-3a16-45a7-b7f1-5521675b0d5c"), false, "Santa Rosa de Cabal", new Guid("3bc8bea0-0772-4466-a1e0-8bf22bf3f2c2") },
                    { new Guid("54b94edb-7730-4313-a7b5-b11fc582c1de"), false, "Granada", new Guid("55bb69fb-01a2-41b0-aa1d-6bb3e3828e46") },
                    { new Guid("57a8cdae-9003-4c9d-83b8-55aa16516d92"), false, "Calarcá", new Guid("5dd698b1-29ba-4728-a324-f64deda85fc9") },
                    { new Guid("5c5577f4-1c69-4d7f-9ad6-28733e074d6f"), false, "Aracataca", new Guid("16f922a3-4c19-432c-a822-415a40f6c13a") },
                    { new Guid("5d1b63e3-77ef-45f1-bebb-019f8108327f"), false, "Honda", new Guid("7faa43bf-7415-4097-8f56-aa900c2fe772") },
                    { new Guid("60be401f-89fd-456a-91be-9c54289fa5f8"), false, "Manizales", new Guid("60991494-70c3-4a03-9ef1-1d1d97429c42") },
                    { new Guid("613e4e18-bdcc-4595-929d-1600fb3b66a2"), false, "La Tebaida", new Guid("5dd698b1-29ba-4728-a324-f64deda85fc9") },
                    { new Guid("648397b4-3b71-4f1a-81fc-40b24a7cd335"), false, "Santa Rosa", new Guid("471dc235-a393-46d6-9dac-e68fded03e44") },
                    { new Guid("667e5dee-e41a-4dee-866b-4fa072bb5679"), false, "Tunja", new Guid("bd57297e-b985-4190-ae3a-2a04ba486325") },
                    { new Guid("66d33583-0cfb-4f74-a10e-01e1fd22a9a4"), false, "Barranquilla", new Guid("62761b57-94ac-49f8-ac2e-a68b54f0985a") },
                    { new Guid("67aa556d-18ac-41de-987d-dce1a0c1a22c"), false, "Leticia", new Guid("6142179e-b85a-445b-b192-13c55e0fde7a") },
                    { new Guid("69470eec-4891-4712-b2d8-cb571f370e73"), false, "Manta", new Guid("29b67093-6129-4ee5-8255-5ba86b1bf59d") },
                    { new Guid("6ab81e51-cd9f-4a41-aff8-26c0f99e8626"), false, "Archidona", new Guid("674ddb31-9a94-45a1-893b-d88d9c6837d6") },
                    { new Guid("6bde3a64-6c2e-4c1f-83d5-d98fbd15b734"), false, "Macas", new Guid("22ee9fff-0a8c-4600-bb17-7eeeff6a2a99") },
                    { new Guid("706bb490-6b0c-462f-b907-446ba54e20ed"), false, "El Tambo", new Guid("e1683fb9-da94-4b64-9402-541b2a65b5bd") },
                    { new Guid("7121ebfd-7dc1-45e6-9945-14f89516d71f"), false, "Palmira", new Guid("714d1455-c57c-4686-9b34-18b663d93d38") },
                    { new Guid("74418bdd-b62f-4028-927e-10740233bab0"), false, "Alausí", new Guid("12408d66-333b-4495-8a5c-b82f577d6483") },
                    { new Guid("74dffbca-1a3a-4aae-949e-e977c8aa57f1"), false, "Cali", new Guid("714d1455-c57c-4686-9b34-18b663d93d38") },
                    { new Guid("75546d87-8873-4c68-9741-c999726ccd19"), false, "Pereira", new Guid("3bc8bea0-0772-4466-a1e0-8bf22bf3f2c2") },
                    { new Guid("7728cb00-1225-46e6-9b2c-9f197ed2aff5"), false, "Puerto Inírida", new Guid("75ad794e-0be4-4cf9-8bd3-162426433a1f") },
                    { new Guid("779398b6-edc4-4a26-b65b-8f5b1db0eb00"), false, "Santa Helena", new Guid("6d184776-b4b5-43e8-972a-0281f7d3cb15") },
                    { new Guid("77c30b63-6e79-4c28-9d51-ff9436182f9e"), false, "Soledad", new Guid("62761b57-94ac-49f8-ac2e-a68b54f0985a") },
                    { new Guid("780ac94b-dd4f-415a-ac91-76405c7ad412"), false, "Magangué", new Guid("5ce551fe-655e-49a7-95ad-e113f65b0e6f") },
                    { new Guid("7ccd0563-a966-4f60-8718-91a66404f8b2"), false, "Aguachica", new Guid("dcf423b2-e93d-41fc-bc0a-8669ee52230d") },
                    { new Guid("7da8269d-7d34-439b-b920-9831512ff309"), false, "Puerto Asís", new Guid("7edc4b28-27d9-404e-9d41-eb112e72b2e3") },
                    { new Guid("80d263bf-1b56-44c5-aba0-9d2f79cadb1a"), false, "Uribia", new Guid("2b0a16b1-5a5c-4520-a885-837980b73ec9") },
                    { new Guid("829c3233-0fcf-43c7-b425-416a952506ef"), false, "Saravena", new Guid("2624291f-182d-4183-84f4-5eaf4fdc2db6") },
                    { new Guid("83251d2c-048b-4940-9778-e466e698292c"), false, "Santander de Quilichao", new Guid("0adc5d72-3b8f-40d6-a55b-039bf971ab21") },
                    { new Guid("832cb8c5-452f-4940-b7d4-634e3703527e"), false, "Chone", new Guid("29b67093-6129-4ee5-8255-5ba86b1bf59d") },
                    { new Guid("85b6ad39-d5f6-4932-ad39-c8b5932b55d4"), false, "Latacunga", new Guid("a437622c-a366-470c-a8c1-6e57ca71689a") },
                    { new Guid("8748d8b8-29de-432d-8b6c-d874291bd3a7"), false, "Montería", new Guid("20d9774c-9e67-434a-8db9-21e14b7aef47") },
                    { new Guid("879b2843-3078-41ef-a59a-2e1c0aba27b5"), false, "La Paz", new Guid("dcf423b2-e93d-41fc-bc0a-8669ee52230d") },
                    { new Guid("8ac5b047-765e-4a06-9208-35483a83e9cd"), false, "La Primavera", new Guid("6d184776-b4b5-43e8-972a-0281f7d3cb15") },
                    { new Guid("8d3235e1-b654-4b45-bec8-fdf7526e878f"), false, "Calamar", new Guid("7816b4fa-f3da-4672-94c3-b827c1e04070") },
                    { new Guid("9199f7ca-d3c1-4aad-b139-3d02aa53dc28"), false, "Lorica", new Guid("20d9774c-9e67-434a-8db9-21e14b7aef47") },
                    { new Guid("92041d07-8908-4eb3-808e-b71570873ec8"), false, "Zipaquirá", new Guid("ef552fa0-def3-4c9f-87a9-5b914387b7d5") },
                    { new Guid("944ce583-9648-432a-9c77-6b6a46f14542"), false, "Valledupar", new Guid("dcf423b2-e93d-41fc-bc0a-8669ee52230d") },
                    { new Guid("953c3d65-a5eb-4744-8d1c-972d9d37f2a9"), false, "Soacha", new Guid("ef552fa0-def3-4c9f-87a9-5b914387b7d5") },
                    { new Guid("958b75c2-f2fb-4e79-9477-1a50454063bd"), false, "Dosquebradas", new Guid("3bc8bea0-0772-4466-a1e0-8bf22bf3f2c2") },
                    { new Guid("96a8ae8d-9731-4d92-a877-ac3bcbe3e26e"), false, "Ibarra", new Guid("3d155301-298f-4294-b9ae-f99f2750ade9") },
                    { new Guid("96eec8cb-30d7-48ee-a3b2-01cc740ecb6d"), false, "Tauramena", new Guid("cc406ecc-7147-4f55-8096-46016755d3d6") },
                    { new Guid("97d06d95-683e-4637-baa1-b5699f555cfb"), false, "Gualaquiza", new Guid("22ee9fff-0a8c-4600-bb17-7eeeff6a2a99") },
                    { new Guid("9cc85076-8a5b-49bf-a7eb-ec931debad85"), false, "Tumaco", new Guid("6ce4ee7c-57ee-456d-a90b-1ff3c9ffc62a") },
                    { new Guid("9d293ca8-0e41-4d25-bbf8-82c232f23da4"), false, "Puerto Baquerizo Moreno", new Guid("0142d0da-56e2-4a6a-8d19-c1447fd88e45") },
                    { new Guid("9ebb8f39-6278-4aea-95e6-7f654635a376"), false, "Durán", new Guid("5a03edca-c978-46ff-94c1-d90fab048198") },
                    { new Guid("9f69cc64-e6cd-4e3b-becc-e852c5668031"), false, "El Guabo", new Guid("0613864e-c378-4e2e-813f-35da9a9745b2") },
                    { new Guid("a2bc46f4-617d-4aa8-a5f2-cfadfa2000c1"), false, "Pamplona", new Guid("02fdcc0c-4ccb-4385-8443-b423f044555c") },
                    { new Guid("a350888c-acdd-43ee-8c17-071ee14c09ed"), false, "Medellín", new Guid("b667da90-18aa-4332-bfcc-98180817039f") },
                    { new Guid("a355bf04-da4d-4818-b3a4-4bb1eff67242"), false, "El Retén", new Guid("7816b4fa-f3da-4672-94c3-b827c1e04070") },
                    { new Guid("a47eb0d7-d871-45ba-b81a-9e42d3235fe5"), false, "Aguazul", new Guid("cc406ecc-7147-4f55-8096-46016755d3d6") },
                    { new Guid("a6bfd88b-4e06-4741-82a6-bb0e5f183211"), false, "Ocaña", new Guid("02fdcc0c-4ccb-4385-8443-b423f044555c") },
                    { new Guid("a8795a4c-c953-4bea-aa36-9307064f3219"), false, "Salcedo", new Guid("a437622c-a366-470c-a8c1-6e57ca71689a") },
                    { new Guid("a998d35a-81c9-4619-a86b-f11d992503fa"), false, "Azogues", new Guid("e1683fb9-da94-4b64-9402-541b2a65b5bd") },
                    { new Guid("abb06001-ad72-40fd-8e10-3a42ab7cae7e"), false, "Orito", new Guid("7edc4b28-27d9-404e-9d41-eb112e72b2e3") },
                    { new Guid("acb83f6c-64d0-452e-b601-a92222aa16e4"), false, "Mocoa", new Guid("7edc4b28-27d9-404e-9d41-eb112e72b2e3") },
                    { new Guid("b22f7f37-1200-4367-8b8d-9ee0d1a7e084"), false, "Guayaquil", new Guid("5a03edca-c978-46ff-94c1-d90fab048198") },
                    { new Guid("b277e4ea-9a38-4f83-a41d-4421a1eb3bd8"), false, "Cartagena de Indias", new Guid("5ce551fe-655e-49a7-95ad-e113f65b0e6f") },
                    { new Guid("b2dd01ae-f2eb-4cbc-98a1-02a2b594d1b7"), false, "Providencia", new Guid("99cd5f3c-b591-4a1a-8574-c5b82ea0d337") },
                    { new Guid("b8306d49-ce74-41cb-b8ba-0bd057f91c01"), false, "Novita", new Guid("885f08a2-3c01-47bd-8362-11e75024e207") },
                    { new Guid("bb385d16-893a-4310-9108-73a85d2ca4a5"), false, "Puerto Carreño", new Guid("6d184776-b4b5-43e8-972a-0281f7d3cb15") },
                    { new Guid("bc07dddd-ffd6-4664-aa20-e012fecfcffb"), false, "Otavalo", new Guid("3d155301-298f-4294-b9ae-f99f2750ade9") },
                    { new Guid("bdf16bce-b945-442d-b59d-c0ea00fab6a8"), false, "Villavicencio", new Guid("55bb69fb-01a2-41b0-aa1d-6bb3e3828e46") },
                    { new Guid("bfb855e0-a9f6-4574-88ca-b63fd02ca980"), false, "Florencia", new Guid("02baec1c-81e0-4f0e-90a1-9107d469777c") },
                    { new Guid("c1206606-0f4d-4045-8af0-cd21b59ef6a7"), false, "Mitú", new Guid("f17a7d74-8a10-49b3-92d9-14f21cc6dd24") },
                    { new Guid("c2544eb3-7b16-467f-8451-a4e746c7ac12"), false, "Tena", new Guid("674ddb31-9a94-45a1-893b-d88d9c6837d6") },
                    { new Guid("c35d297e-e211-4424-a19a-f56fd923f297"), false, "Arauca", new Guid("2624291f-182d-4183-84f4-5eaf4fdc2db6") },
                    { new Guid("c4bd3f2c-b8cc-46f0-b423-eed06cdc2d6a"), false, "Yopal", new Guid("cc406ecc-7147-4f55-8096-46016755d3d6") },
                    { new Guid("c6215ccf-f6bb-4651-af2e-e540fc151fb5"), false, "Machala", new Guid("471dc235-a393-46d6-9dac-e68fded03e44") },
                    { new Guid("c675d340-117a-4a81-a07f-1afb9adc1f1c"), false, "Saraguro", new Guid("8a92bf7a-8302-4e80-871d-fbd4340c9b81") },
                    { new Guid("ca14a316-11fd-47ff-8eec-9354029a9acb"), false, "Loja", new Guid("8a92bf7a-8302-4e80-871d-fbd4340c9b81") },
                    { new Guid("ca595c0c-edc5-410b-ad23-55367af0028b"), false, "Portoviejo", new Guid("29b67093-6129-4ee5-8255-5ba86b1bf59d") },
                    { new Guid("cb596d7c-8c4d-4068-b5c8-bcbe68d04a61"), false, "Buenaventura", new Guid("714d1455-c57c-4686-9b34-18b663d93d38") },
                    { new Guid("cd14e393-9acd-4057-8f56-0ba0568e6a3f"), false, "San Andrés", new Guid("99cd5f3c-b591-4a1a-8574-c5b82ea0d337") },
                    { new Guid("cdba1c83-635e-45ee-9994-0869f3e5f1f0"), false, "Pereira", new Guid("60991494-70c3-4a03-9ef1-1d1d97429c42") },
                    { new Guid("d4f30256-322d-4516-9635-52ce0a7e08cd"), false, "Santa Catalina", new Guid("99cd5f3c-b591-4a1a-8574-c5b82ea0d337") },
                    { new Guid("d97f35c9-27b7-400f-b9db-879bd9103598"), false, "Girón", new Guid("9e19aff9-071a-4173-9f03-188d08d8a269") },
                    { new Guid("dbbaeb56-13ca-4731-8a28-6eee80aa29e7"), false, "Cereté", new Guid("20d9774c-9e67-434a-8db9-21e14b7aef47") },
                    { new Guid("df3f27a1-0f48-479d-8fb7-f15818462b6f"), false, "Memarí", new Guid("75ad794e-0be4-4cf9-8bd3-162426433a1f") },
                    { new Guid("e4d6e2cc-9a65-49ed-8c99-229d96ae688e"), false, "Chinchiná", new Guid("60991494-70c3-4a03-9ef1-1d1d97429c42") },
                    { new Guid("e4eef7a9-de9d-454b-92c4-136d4bad12fd"), false, "Inírida", new Guid("75ad794e-0be4-4cf9-8bd3-162426433a1f") },
                    { new Guid("e65a8883-fc11-407c-b9ea-9bcafa16bc08"), false, "Cartagena del Chairá", new Guid("02baec1c-81e0-4f0e-90a1-9107d469777c") },
                    { new Guid("e6a880f7-4841-4532-9ff9-781f93f7af95"), false, "Silvia", new Guid("0adc5d72-3b8f-40d6-a55b-039bf971ab21") },
                    { new Guid("e78d3674-2661-40f9-a631-91309fc5e170"), false, "Santa Rosalía", new Guid("f17a7d74-8a10-49b3-92d9-14f21cc6dd24") },
                    { new Guid("e7926c43-fe03-4e61-bdf6-5ddf441fee97"), false, "Sincelejo", new Guid("c6da6aa6-0d49-449d-8487-b940f4ce1648") },
                    { new Guid("e7d7c30a-73ea-4065-bd20-d73e0ad5da7e"), false, "Piedecuesta", new Guid("3accd102-139e-4b54-a266-dba40c5a1d77") },
                    { new Guid("ea3a972c-981c-4a28-a7a1-788565c57603"), false, "Cuenca", new Guid("9e19aff9-071a-4173-9f03-188d08d8a269") },
                    { new Guid("efcc3454-6316-44c8-9d07-943fd25216cf"), false, "Garzón", new Guid("f1df1f3f-5616-444d-9bff-9ff1b94a0c56") },
                    { new Guid("f001c309-806a-487e-adf5-5225854d4733"), false, "Popayán", new Guid("0adc5d72-3b8f-40d6-a55b-039bf971ab21") },
                    { new Guid("f05bb9d7-2f09-4c70-86d1-63590652a70e"), false, "Bucaramanga", new Guid("3accd102-139e-4b54-a266-dba40c5a1d77") },
                    { new Guid("f73086a8-a50e-4fb5-8670-fa6b901ea95e"), false, "Bogotá", new Guid("ef552fa0-def3-4c9f-87a9-5b914387b7d5") },
                    { new Guid("f94d18ea-d353-453b-821d-cfde3786fa30"), false, "Cúcuta", new Guid("02fdcc0c-4ccb-4385-8443-b423f044555c") },
                    { new Guid("fd67d2e7-5640-43e6-8036-f102032ca31a"), false, "Fortul", new Guid("2624291f-182d-4183-84f4-5eaf4fdc2db6") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_city_cty_name_prv_province_id",
                table: "city",
                columns: new[] { "cty_name", "prv_province_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_city_prv_province_id",
                table: "city",
                column: "prv_province_id");

            migrationBuilder.CreateIndex(
                name: "IX_country_ctr_name",
                table: "country",
                column: "ctr_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_level_rol_name",
                table: "level",
                column: "rol_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_professional_prf_email",
                table: "professional",
                column: "prf_email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_province_ctr_country_id",
                table: "province",
                column: "ctr_country_id");

            migrationBuilder.CreateIndex(
                name: "IX_province_prv_name_ctr_country_id",
                table: "province",
                columns: new[] { "prv_name", "ctr_country_id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_role_rol_name",
                table: "role",
                column: "rol_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_skill_skl_name",
                table: "skill",
                column: "skl_name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "level");

            migrationBuilder.DropTable(
                name: "professional");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "province");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
