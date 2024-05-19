﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Profiles.Infrastructure.Persistence;

#nullable disable

namespace Profiles.Infrastructure.Migrations
{
  [DbContext(typeof(ApplicationDbContext))]
  [Migration("20240428104047_AddTablesAndSeeds")]
  partial class AddTablesAndSeeds
  {
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
      modelBuilder
      .HasAnnotation("ProductVersion", "8.0.4")
      .HasAnnotation("Relational:MaxIdentifierLength", 63);

      NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.CityModel", b =>
      {
        b.Property<Guid>("CityId")
  .HasColumnType("uuid")
  .HasColumnName("cty_city_id");

        b.Property<bool>("Disabled")
  .HasColumnType("boolean")
  .HasColumnName("cty_disabled");

        b.Property<string>("Name")
  .IsRequired()
  .HasMaxLength(100)
  .HasColumnType("character varying(100)")
  .HasColumnName("cty_name");

        b.Property<Guid>("ProvinceId")
  .HasColumnType("uuid")
  .HasColumnName("prv_province_id");

        b.HasKey("CityId");

        b.HasIndex("ProvinceId");

        b.HasIndex("Name", "ProvinceId")
  .IsUnique();

        b.ToTable("city");

        b.HasData(
  new
  {
    CityId = new Guid("25b0e4e9-8138-49c0-b7b0-e3bea6dabe64"),
    Disabled = false,
    Name = "Leticia",
    ProvinceId = new Guid("fb75bdf5-a843-4761-9aee-2b1200be26d5")
  },
  new
  {
    CityId = new Guid("f7feb7ea-1415-4e08-b991-94b9159ca605"),
    Disabled = false,
    Name = "Medellín",
    ProvinceId = new Guid("cd7f27b3-293b-4f44-8136-a466f8ff9525")
  },
  new
  {
    CityId = new Guid("a9823fa9-0f24-4930-8370-6c7c191a64e8"),
    Disabled = false,
    Name = "Apartadó",
    ProvinceId = new Guid("cd7f27b3-293b-4f44-8136-a466f8ff9525")
  },
  new
  {
    CityId = new Guid("35aa60f2-504c-40bc-b0f1-abebd5b6c0e2"),
    Disabled = false,
    Name = "Turbo",
    ProvinceId = new Guid("cd7f27b3-293b-4f44-8136-a466f8ff9525")
  },
  new
  {
    CityId = new Guid("1d462095-5a07-47b4-a167-caa4ceff2632"),
    Disabled = false,
    Name = "Arauca",
    ProvinceId = new Guid("71860591-cf14-48a9-a06f-c68eccb2d8c1")
  },
  new
  {
    CityId = new Guid("b1b29a62-5293-4a0c-986e-00563abd45f4"),
    Disabled = false,
    Name = "Saravena",
    ProvinceId = new Guid("71860591-cf14-48a9-a06f-c68eccb2d8c1")
  },
  new
  {
    CityId = new Guid("7c5b2a3c-b949-4cca-bb50-b6c77dafaaf9"),
    Disabled = false,
    Name = "Fortul",
    ProvinceId = new Guid("71860591-cf14-48a9-a06f-c68eccb2d8c1")
  },
  new
  {
    CityId = new Guid("73c0b0a6-6208-4e9a-84da-5a2a3e1ccc7a"),
    Disabled = false,
    Name = "Barranquilla",
    ProvinceId = new Guid("286cd1ec-ee8f-47e6-b17e-88958107298b")
  },
  new
  {
    CityId = new Guid("fbef7cab-ba82-4a82-82a9-d912523be4c2"),
    Disabled = false,
    Name = "Soledad",
    ProvinceId = new Guid("286cd1ec-ee8f-47e6-b17e-88958107298b")
  },
  new
  {
    CityId = new Guid("d331b050-7958-4fbe-9075-f2723871c687"),
    Disabled = false,
    Name = "Puerto Colombia",
    ProvinceId = new Guid("286cd1ec-ee8f-47e6-b17e-88958107298b")
  },
  new
  {
    CityId = new Guid("297f93c4-51ad-4a45-9464-1de9b413a89b"),
    Disabled = false,
    Name = "Cartagena de Indias",
    ProvinceId = new Guid("c77fbe3f-af07-45c7-ad0d-b594760cb97c")
  },
  new
  {
    CityId = new Guid("f3119965-8cf4-45f9-908e-d9682d3bdfa2"),
    Disabled = false,
    Name = "Magangué",
    ProvinceId = new Guid("c77fbe3f-af07-45c7-ad0d-b594760cb97c")
  },
  new
  {
    CityId = new Guid("eb5d5d7e-a96f-45db-800e-466f2e670a1b"),
    Disabled = false,
    Name = "Cartagena del Chairá",
    ProvinceId = new Guid("c77fbe3f-af07-45c7-ad0d-b594760cb97c")
  },
  new
  {
    CityId = new Guid("fa600836-98bb-4adf-8db7-d6cde08a132a"),
    Disabled = false,
    Name = "Tunja",
    ProvinceId = new Guid("40744b42-e290-4596-90f5-b7a8b140236b")
  },
  new
  {
    CityId = new Guid("05935a88-781d-406e-aac0-5f58b52631e6"),
    Disabled = false,
    Name = "Sogamoso",
    ProvinceId = new Guid("40744b42-e290-4596-90f5-b7a8b140236b")
  },
  new
  {
    CityId = new Guid("8ab1725d-34f7-4bc6-9452-969096cc237b"),
    Disabled = false,
    Name = "Duitama",
    ProvinceId = new Guid("40744b42-e290-4596-90f5-b7a8b140236b")
  },
  new
  {
    CityId = new Guid("53ac9d5e-f686-43ee-ba3d-f89f38523ded"),
    Disabled = false,
    Name = "Manizales",
    ProvinceId = new Guid("ed5f6e76-e8fa-4e0e-9bbf-9ad362dea113")
  },
  new
  {
    CityId = new Guid("c7599b17-cf04-4bd6-8d45-1bebbf369bb6"),
    Disabled = false,
    Name = "Pereira",
    ProvinceId = new Guid("ed5f6e76-e8fa-4e0e-9bbf-9ad362dea113")
  },
  new
  {
    CityId = new Guid("096c1f12-1514-4cb1-9892-b273432fdf27"),
    Disabled = false,
    Name = "Chinchiná",
    ProvinceId = new Guid("ed5f6e76-e8fa-4e0e-9bbf-9ad362dea113")
  },
  new
  {
    CityId = new Guid("b16fb17f-e7cd-42ef-877c-3cddadd7bc7e"),
    Disabled = false,
    Name = "Florencia",
    ProvinceId = new Guid("d7450556-7eba-4cf3-8461-318e8b6f7e53")
  },
  new
  {
    CityId = new Guid("0994c22b-6ba3-474a-93d4-c3423ee6d702"),
    Disabled = false,
    Name = "Cartagena del Chairá",
    ProvinceId = new Guid("d7450556-7eba-4cf3-8461-318e8b6f7e53")
  },
  new
  {
    CityId = new Guid("0c321aec-617b-441c-9f09-1ef2c1f503bc"),
    Disabled = false,
    Name = "Morelia",
    ProvinceId = new Guid("d7450556-7eba-4cf3-8461-318e8b6f7e53")
  },
  new
  {
    CityId = new Guid("30709fdd-67a5-48c4-81c9-6d5e9ed8d034"),
    Disabled = false,
    Name = "Yopal",
    ProvinceId = new Guid("4e4cdf78-9ff6-4ea5-bfbd-c37bad442e85")
  },
  new
  {
    CityId = new Guid("80797cb7-520b-42af-b4e8-d68fac195539"),
    Disabled = false,
    Name = "Aguazul",
    ProvinceId = new Guid("4e4cdf78-9ff6-4ea5-bfbd-c37bad442e85")
  },
  new
  {
    CityId = new Guid("505d2859-7011-48b2-bf1f-cd5cd82e36c8"),
    Disabled = false,
    Name = "Tauramena",
    ProvinceId = new Guid("4e4cdf78-9ff6-4ea5-bfbd-c37bad442e85")
  },
  new
  {
    CityId = new Guid("a62ece73-ed9a-4145-a707-fe3441966573"),
    Disabled = false,
    Name = "Popayán",
    ProvinceId = new Guid("3fc8c2e7-d2c3-4a7e-88e5-dd9e0a62e0e6")
  },
  new
  {
    CityId = new Guid("590afea8-f00b-4057-b7f0-ca4c78db2f6b"),
    Disabled = false,
    Name = "Silvia",
    ProvinceId = new Guid("3fc8c2e7-d2c3-4a7e-88e5-dd9e0a62e0e6")
  },
  new
  {
    CityId = new Guid("f4a4f00d-d422-414b-8f5b-b9e4a92dbecc"),
    Disabled = false,
    Name = "Santander de Quilichao",
    ProvinceId = new Guid("3fc8c2e7-d2c3-4a7e-88e5-dd9e0a62e0e6")
  },
  new
  {
    CityId = new Guid("b689890e-7076-48e4-8d6e-619c7b629c92"),
    Disabled = false,
    Name = "Valledupar",
    ProvinceId = new Guid("4cfb18bd-fe66-45d8-afcc-edc70dc78d1b")
  },
  new
  {
    CityId = new Guid("fc2ecf61-6749-4e9c-8bad-1111be4739a9"),
    Disabled = false,
    Name = "Aguachica",
    ProvinceId = new Guid("4cfb18bd-fe66-45d8-afcc-edc70dc78d1b")
  },
  new
  {
    CityId = new Guid("84ad4043-faae-4d97-b4bc-48e6740c3349"),
    Disabled = false,
    Name = "La Paz",
    ProvinceId = new Guid("4cfb18bd-fe66-45d8-afcc-edc70dc78d1b")
  },
  new
  {
    CityId = new Guid("8d374b54-8acc-4477-b616-d80d1917b966"),
    Disabled = false,
    Name = "Quibdó",
    ProvinceId = new Guid("31fafa3c-8545-48fc-a248-c70016be95fa")
  },
  new
  {
    CityId = new Guid("b1319aad-59cb-432f-b06f-dd6444b9da81"),
    Disabled = false,
    Name = "Istmina",
    ProvinceId = new Guid("31fafa3c-8545-48fc-a248-c70016be95fa")
  },
  new
  {
    CityId = new Guid("be06cff4-90f1-4658-8f3b-aafcb5989734"),
    Disabled = false,
    Name = "Novita",
    ProvinceId = new Guid("31fafa3c-8545-48fc-a248-c70016be95fa")
  },
  new
  {
    CityId = new Guid("f3973f38-379c-4b4a-98b6-51b992affcfd"),
    Disabled = false,
    Name = "Montería",
    ProvinceId = new Guid("b87f01bd-31ee-42aa-b985-c807c30dd9cb")
  },
  new
  {
    CityId = new Guid("a57e241f-d7eb-43a7-a6a7-03a40fe6a267"),
    Disabled = false,
    Name = "Cereté",
    ProvinceId = new Guid("b87f01bd-31ee-42aa-b985-c807c30dd9cb")
  },
  new
  {
    CityId = new Guid("cdf39286-925b-4e50-a836-a913d3522973"),
    Disabled = false,
    Name = "Lorica",
    ProvinceId = new Guid("b87f01bd-31ee-42aa-b985-c807c30dd9cb")
  },
  new
  {
    CityId = new Guid("6838f0e8-35f8-44d7-9589-6cc525266bb2"),
    Disabled = false,
    Name = "Bogotá",
    ProvinceId = new Guid("d3427d27-320e-4808-8757-437c856d18ac")
  },
  new
  {
    CityId = new Guid("dd2a1ae9-c662-454a-a882-afa18b0ca5eb"),
    Disabled = false,
    Name = "Soacha",
    ProvinceId = new Guid("d3427d27-320e-4808-8757-437c856d18ac")
  },
  new
  {
    CityId = new Guid("e6f1ffaa-9838-4035-8d30-3597380e028b"),
    Disabled = false,
    Name = "Zipaquirá",
    ProvinceId = new Guid("d3427d27-320e-4808-8757-437c856d18ac")
  },
  new
  {
    CityId = new Guid("83b10cf2-88ae-490c-a08d-56669df4639c"),
    Disabled = false,
    Name = "Inírida",
    ProvinceId = new Guid("0ec08a72-79fc-4b7e-865c-db1951bfc5d0")
  },
  new
  {
    CityId = new Guid("cb26c69f-a115-48b8-a45b-ab7e2f35b5ac"),
    Disabled = false,
    Name = "Puerto Inírida",
    ProvinceId = new Guid("0ec08a72-79fc-4b7e-865c-db1951bfc5d0")
  },
  new
  {
    CityId = new Guid("c229fe3e-a4bc-482e-b13d-fad40ead0234"),
    Disabled = false,
    Name = "Memarí",
    ProvinceId = new Guid("0ec08a72-79fc-4b7e-865c-db1951bfc5d0")
  },
  new
  {
    CityId = new Guid("7416886a-7bb1-4627-9678-0f3558ee74c0"),
    Disabled = false,
    Name = "San José del Guaviare",
    ProvinceId = new Guid("db82d3b8-24d5-4ebe-8814-528a8b0948f2")
  },
  new
  {
    CityId = new Guid("2de9ad19-59c8-47b0-bd5d-5971ac7fb20b"),
    Disabled = false,
    Name = "Calamar",
    ProvinceId = new Guid("db82d3b8-24d5-4ebe-8814-528a8b0948f2")
  },
  new
  {
    CityId = new Guid("4f7ad539-551d-41c4-9a08-a0cbd1e034cd"),
    Disabled = false,
    Name = "El Retén",
    ProvinceId = new Guid("db82d3b8-24d5-4ebe-8814-528a8b0948f2")
  },
  new
  {
    CityId = new Guid("249c6e50-82a7-4fc1-ab5d-52d329dd3a3a"),
    Disabled = false,
    Name = "Neiva",
    ProvinceId = new Guid("94d89b69-c4c7-4606-b059-63c1a9b656d5")
  },
  new
  {
    CityId = new Guid("d324b373-6ca4-4fde-a84d-bd03f0d4563c"),
    Disabled = false,
    Name = "Garzón",
    ProvinceId = new Guid("94d89b69-c4c7-4606-b059-63c1a9b656d5")
  },
  new
  {
    CityId = new Guid("a6252e21-5f78-46cd-868a-cab609b2b419"),
    Disabled = false,
    Name = "Pitalito",
    ProvinceId = new Guid("94d89b69-c4c7-4606-b059-63c1a9b656d5")
  },
  new
  {
    CityId = new Guid("8ea3eac7-3b85-4f95-9293-53cbb2ec24a0"),
    Disabled = false,
    Name = "Riohacha",
    ProvinceId = new Guid("c6818890-d8f6-48b5-9cbd-9e12579d6d1a")
  },
  new
  {
    CityId = new Guid("0bf42ad8-ea2f-4d3b-838f-685b7062026e"),
    Disabled = false,
    Name = "Maicao",
    ProvinceId = new Guid("c6818890-d8f6-48b5-9cbd-9e12579d6d1a")
  },
  new
  {
    CityId = new Guid("61d939cd-64f1-4afb-8894-169795c6b6c5"),
    Disabled = false,
    Name = "Uribia",
    ProvinceId = new Guid("c6818890-d8f6-48b5-9cbd-9e12579d6d1a")
  },
  new
  {
    CityId = new Guid("17940812-5d18-42ac-938a-18c9b8dfe9bd"),
    Disabled = false,
    Name = "Santa Marta",
    ProvinceId = new Guid("77dc62b7-1b37-4316-bc0f-67901e36cbf3")
  },
  new
  {
    CityId = new Guid("0fcf8154-fda3-4f7b-ae68-b53f442fd6d7"),
    Disabled = false,
    Name = "Aracataca",
    ProvinceId = new Guid("77dc62b7-1b37-4316-bc0f-67901e36cbf3")
  },
  new
  {
    CityId = new Guid("da015a1a-2c78-4888-ac00-3d53eeadd3fb"),
    Disabled = false,
    Name = "Ciénaga",
    ProvinceId = new Guid("77dc62b7-1b37-4316-bc0f-67901e36cbf3")
  },
  new
  {
    CityId = new Guid("86fbca92-1115-440a-a181-3f694ad3def1"),
    Disabled = false,
    Name = "Villavicencio",
    ProvinceId = new Guid("b9ac4bcb-a6e2-494f-a7d8-3500576e5d75")
  },
  new
  {
    CityId = new Guid("f00486ec-e5db-460c-b5cf-cfcde5f947dc"),
    Disabled = false,
    Name = "Acacias",
    ProvinceId = new Guid("b9ac4bcb-a6e2-494f-a7d8-3500576e5d75")
  },
  new
  {
    CityId = new Guid("e1893eb3-72d2-492b-82e4-9cc15e772294"),
    Disabled = false,
    Name = "Granada",
    ProvinceId = new Guid("b9ac4bcb-a6e2-494f-a7d8-3500576e5d75")
  },
  new
  {
    CityId = new Guid("5df7dee2-450a-4e52-8526-1891f1f01319"),
    Disabled = false,
    Name = "San Juan de Pasto",
    ProvinceId = new Guid("06189287-3dcb-49f0-90c0-fcd95b95e327")
  },
  new
  {
    CityId = new Guid("413f1350-699d-438a-a377-09238102413d"),
    Disabled = false,
    Name = "Tumaco",
    ProvinceId = new Guid("06189287-3dcb-49f0-90c0-fcd95b95e327")
  },
  new
  {
    CityId = new Guid("59056932-865d-40f7-835b-5fcb8a4b2989"),
    Disabled = false,
    Name = "Ipiales",
    ProvinceId = new Guid("06189287-3dcb-49f0-90c0-fcd95b95e327")
  },
  new
  {
    CityId = new Guid("8afb71e3-0778-4069-8114-a91f44c9b137"),
    Disabled = false,
    Name = "Cúcuta",
    ProvinceId = new Guid("2cfcb757-0670-4bb6-99d6-5e9922e7326b")
  },
  new
  {
    CityId = new Guid("63958570-f4ca-42b3-be69-2cbe4cf12ce0"),
    Disabled = false,
    Name = "Ocaña",
    ProvinceId = new Guid("2cfcb757-0670-4bb6-99d6-5e9922e7326b")
  },
  new
  {
    CityId = new Guid("df5d167c-00fb-4e0f-abe3-3761942cdac8"),
    Disabled = false,
    Name = "Pamplona",
    ProvinceId = new Guid("2cfcb757-0670-4bb6-99d6-5e9922e7326b")
  },
  new
  {
    CityId = new Guid("66a79d2c-94f2-4144-a55c-9fe70e597ca6"),
    Disabled = false,
    Name = "Mocoa",
    ProvinceId = new Guid("0609ac6f-5a8c-4cdb-ba77-a2c4e468ae95")
  },
  new
  {
    CityId = new Guid("13f1b8b2-bff2-4e80-9490-ef27e5089f20"),
    Disabled = false,
    Name = "Puerto Asís",
    ProvinceId = new Guid("0609ac6f-5a8c-4cdb-ba77-a2c4e468ae95")
  },
  new
  {
    CityId = new Guid("e0d9cfab-67f3-4214-89f4-cb1719f94ca0"),
    Disabled = false,
    Name = "Orito",
    ProvinceId = new Guid("0609ac6f-5a8c-4cdb-ba77-a2c4e468ae95")
  },
  new
  {
    CityId = new Guid("e0ecba4e-15bc-4fbb-b7c7-130223de4f84"),
    Disabled = false,
    Name = "Armenia",
    ProvinceId = new Guid("aa85be1f-abe2-4751-8da7-38a2b930b527")
  },
  new
  {
    CityId = new Guid("06a01308-5542-4c38-942d-94d81305c49d"),
    Disabled = false,
    Name = "Calarcá",
    ProvinceId = new Guid("aa85be1f-abe2-4751-8da7-38a2b930b527")
  },
  new
  {
    CityId = new Guid("fe381bd9-736d-4a60-99bf-c36122d08a38"),
    Disabled = false,
    Name = "La Tebaida",
    ProvinceId = new Guid("aa85be1f-abe2-4751-8da7-38a2b930b527")
  },
  new
  {
    CityId = new Guid("13b51b44-085a-48ef-8611-321ee7077f29"),
    Disabled = false,
    Name = "Pereira",
    ProvinceId = new Guid("1ba2474d-58d2-4e82-8e59-cae097423d56")
  },
  new
  {
    CityId = new Guid("1a495b17-7a54-4345-8f8d-4ff75555ea64"),
    Disabled = false,
    Name = "Dosquebradas",
    ProvinceId = new Guid("1ba2474d-58d2-4e82-8e59-cae097423d56")
  },
  new
  {
    CityId = new Guid("d5bb6c86-6d27-4a5f-8c31-b09cbb0d3257"),
    Disabled = false,
    Name = "Santa Rosa de Cabal",
    ProvinceId = new Guid("1ba2474d-58d2-4e82-8e59-cae097423d56")
  },
  new
  {
    CityId = new Guid("5c12cd9a-97b5-4387-8bbb-6546c648eed6"),
    Disabled = false,
    Name = "San Andrés",
    ProvinceId = new Guid("be362bcd-e59d-4ea3-bf20-cd3bcc17c204")
  },
  new
  {
    CityId = new Guid("a5aa2dd6-3653-4d74-bc3c-ad563043a38b"),
    Disabled = false,
    Name = "Providencia",
    ProvinceId = new Guid("be362bcd-e59d-4ea3-bf20-cd3bcc17c204")
  },
  new
  {
    CityId = new Guid("e5f3c29f-b832-4105-a178-f4b4bda4a16c"),
    Disabled = false,
    Name = "Santa Catalina",
    ProvinceId = new Guid("be362bcd-e59d-4ea3-bf20-cd3bcc17c204")
  },
  new
  {
    CityId = new Guid("7de9c2cd-92dc-4f40-ba45-9b4a8bbd7c5f"),
    Disabled = false,
    Name = "Bucaramanga",
    ProvinceId = new Guid("8f8a595a-c58d-4ee8-a148-40cbb003c03f")
  },
  new
  {
    CityId = new Guid("78350552-a174-47d6-8fd1-37f1a0491dc0"),
    Disabled = false,
    Name = "Barrancabermeja",
    ProvinceId = new Guid("8f8a595a-c58d-4ee8-a148-40cbb003c03f")
  },
  new
  {
    CityId = new Guid("b61940b2-a3d8-40b8-9edb-dd383f651c93"),
    Disabled = false,
    Name = "Piedecuesta",
    ProvinceId = new Guid("8f8a595a-c58d-4ee8-a148-40cbb003c03f")
  },
  new
  {
    CityId = new Guid("4eb0057b-6de3-433a-bf2e-3df5f814b7d7"),
    Disabled = false,
    Name = "Sincelejo",
    ProvinceId = new Guid("2182384c-72d0-4cd8-8479-168b185cb08a")
  },
  new
  {
    CityId = new Guid("b7a05aff-a9b4-4efc-b87f-86e778d0c5de"),
    Disabled = false,
    Name = "Corozal",
    ProvinceId = new Guid("2182384c-72d0-4cd8-8479-168b185cb08a")
  },
  new
  {
    CityId = new Guid("9b713863-ddf4-4850-9844-9c5114d14c2d"),
    Disabled = false,
    Name = "Montería",
    ProvinceId = new Guid("2182384c-72d0-4cd8-8479-168b185cb08a")
  },
  new
  {
    CityId = new Guid("65565762-b61a-44ba-a238-cb501e12687d"),
    Disabled = false,
    Name = "Ibagué",
    ProvinceId = new Guid("bbe7ef02-cfa6-4bd7-bf26-4246282e13b2")
  },
  new
  {
    CityId = new Guid("e6fede83-0e1b-41ab-a4cc-aa72cbbcf866"),
    Disabled = false,
    Name = "Honda",
    ProvinceId = new Guid("bbe7ef02-cfa6-4bd7-bf26-4246282e13b2")
  },
  new
  {
    CityId = new Guid("bc76c92b-e65c-4a52-aae4-9abe8c868e3b"),
    Disabled = false,
    Name = "Armero Guayabal",
    ProvinceId = new Guid("bbe7ef02-cfa6-4bd7-bf26-4246282e13b2")
  },
  new
  {
    CityId = new Guid("d3b577a4-ffa2-493e-b377-dfb822cd149e"),
    Disabled = false,
    Name = "Cali",
    ProvinceId = new Guid("1b586621-1fef-424e-81fa-bec0fb285679")
  },
  new
  {
    CityId = new Guid("37f2b886-fbad-4286-84bc-728fb923ffd0"),
    Disabled = false,
    Name = "Palmira",
    ProvinceId = new Guid("1b586621-1fef-424e-81fa-bec0fb285679")
  },
  new
  {
    CityId = new Guid("46559a23-0272-47ef-b1eb-e891caced216"),
    Disabled = false,
    Name = "Buenaventura",
    ProvinceId = new Guid("1b586621-1fef-424e-81fa-bec0fb285679")
  },
  new
  {
    CityId = new Guid("1c2b18b2-abdb-483a-91af-df9d9053e304"),
    Disabled = false,
    Name = "Mitú",
    ProvinceId = new Guid("b8a17803-d01b-4142-96b8-5d7c8b2d1958")
  },
  new
  {
    CityId = new Guid("b94d5107-2532-4f42-8385-a557f67119ba"),
    Disabled = false,
    Name = "Yavaraté",
    ProvinceId = new Guid("b8a17803-d01b-4142-96b8-5d7c8b2d1958")
  },
  new
  {
    CityId = new Guid("ef3e939f-0e2f-45ee-81d1-f313caa955a2"),
    Disabled = false,
    Name = "Santa Rosalía",
    ProvinceId = new Guid("b8a17803-d01b-4142-96b8-5d7c8b2d1958")
  },
  new
  {
    CityId = new Guid("dfe5ee3e-f678-4d86-8a2d-bf58fae0eaff"),
    Disabled = false,
    Name = "Puerto Carreño",
    ProvinceId = new Guid("289c8325-899d-4e9c-bb26-da8a2fbd68b2")
  },
  new
  {
    CityId = new Guid("524d3e97-512a-40ba-b028-1ca5c5702a84"),
    Disabled = false,
    Name = "La Primavera",
    ProvinceId = new Guid("289c8325-899d-4e9c-bb26-da8a2fbd68b2")
  },
  new
  {
    CityId = new Guid("72073614-070c-4287-81c7-8a97e4fcc801"),
    Disabled = false,
    Name = "Santa Helena",
    ProvinceId = new Guid("289c8325-899d-4e9c-bb26-da8a2fbd68b2")
  },
  new
  {
    CityId = new Guid("9b84c296-837e-45df-9be0-b08e676c9deb"),
    Disabled = false,
    Name = "Cuenca",
    ProvinceId = new Guid("e05ddb61-7b4a-4fb0-85f7-fcd8f7c0cb55")
  },
  new
  {
    CityId = new Guid("d5acdcb3-a55d-4f19-a3c6-3ab477ea867d"),
    Disabled = false,
    Name = "Girón",
    ProvinceId = new Guid("e05ddb61-7b4a-4fb0-85f7-fcd8f7c0cb55")
  },
  new
  {
    CityId = new Guid("56cc4dad-0b07-46bb-9dd9-7bc1fd06fdaf"),
    Disabled = false,
    Name = "Guaranda",
    ProvinceId = new Guid("fedf041f-4b2b-485b-8d33-685e877b6576")
  },
  new
  {
    CityId = new Guid("f2a47fda-514e-4df6-8762-bd5635b879c7"),
    Disabled = false,
    Name = "San Miguel de Bolívar",
    ProvinceId = new Guid("fedf041f-4b2b-485b-8d33-685e877b6576")
  },
  new
  {
    CityId = new Guid("165ecc8c-2377-4e63-9a82-60850ee58bdd"),
    Disabled = false,
    Name = "Azogues",
    ProvinceId = new Guid("d100d89d-0c05-4131-b940-a850873b0718")
  },
  new
  {
    CityId = new Guid("fab0b269-8cff-46a2-b309-c96430d8e41f"),
    Disabled = false,
    Name = "El Tambo",
    ProvinceId = new Guid("d100d89d-0c05-4131-b940-a850873b0718")
  },
  new
  {
    CityId = new Guid("4fdf91e7-2efb-4d16-9471-5cb3a9e92ee3"),
    Disabled = false,
    Name = "Tulcán",
    ProvinceId = new Guid("3d892b15-f5ae-4b61-bcca-5168bf56748d")
  },
  new
  {
    CityId = new Guid("ca58d79c-2190-4bb9-8d45-dcd7f24d66c1"),
    Disabled = false,
    Name = "El Guabo",
    ProvinceId = new Guid("3d892b15-f5ae-4b61-bcca-5168bf56748d")
  },
  new
  {
    CityId = new Guid("55dff2dc-1b0b-419d-8380-2ee7a38aec40"),
    Disabled = false,
    Name = "Riobamba",
    ProvinceId = new Guid("28daa4f8-3dc4-4801-aa1b-057acb3b6f18")
  },
  new
  {
    CityId = new Guid("91ab6c29-21aa-40b0-abec-f79ceb0bda66"),
    Disabled = false,
    Name = "Alausí",
    ProvinceId = new Guid("28daa4f8-3dc4-4801-aa1b-057acb3b6f18")
  },
  new
  {
    CityId = new Guid("d32acf5a-4850-4412-b143-63335262a229"),
    Disabled = false,
    Name = "Latacunga",
    ProvinceId = new Guid("00997a7b-f986-47c5-a2d4-62b2993797b7")
  },
  new
  {
    CityId = new Guid("eeabbbce-1468-4243-8aba-046c3ed0fc1c"),
    Disabled = false,
    Name = "Salcedo",
    ProvinceId = new Guid("00997a7b-f986-47c5-a2d4-62b2993797b7")
  },
  new
  {
    CityId = new Guid("05e86940-4993-4bb7-90a5-f25ebb586f0d"),
    Disabled = false,
    Name = "Machala",
    ProvinceId = new Guid("220ee83b-77ef-4ae1-a0aa-b7d5d2eabc9d")
  },
  new
  {
    CityId = new Guid("6100d10a-7e63-4cc3-aaaf-3423232c39f4"),
    Disabled = false,
    Name = "Santa Rosa",
    ProvinceId = new Guid("220ee83b-77ef-4ae1-a0aa-b7d5d2eabc9d")
  },
  new
  {
    CityId = new Guid("7d926719-0043-419b-a233-971b594a52db"),
    Disabled = false,
    Name = "Esmeraldas",
    ProvinceId = new Guid("8c028c6e-2626-4ade-b031-a1ea14c56ffc")
  },
  new
  {
    CityId = new Guid("4b2bb92e-7791-49f8-8d7c-14c8a0a64f84"),
    Disabled = false,
    Name = "Atacames",
    ProvinceId = new Guid("8c028c6e-2626-4ade-b031-a1ea14c56ffc")
  },
  new
  {
    CityId = new Guid("ca15098e-ba0a-42f4-8b8e-765ee69ec5d0"),
    Disabled = false,
    Name = "Puerto Baquerizo Moreno",
    ProvinceId = new Guid("5ddb40a0-df7b-44fd-9596-676db9a50bd4")
  },
  new
  {
    CityId = new Guid("604df23e-1aa6-4698-b86b-7d19a091ccd4"),
    Disabled = false,
    Name = "San Cristóbal",
    ProvinceId = new Guid("5ddb40a0-df7b-44fd-9596-676db9a50bd4")
  },
  new
  {
    CityId = new Guid("716c1be3-b989-424b-9e58-f49d745a9240"),
    Disabled = false,
    Name = "Guayaquil",
    ProvinceId = new Guid("757ba0c1-d96b-4da3-b2a6-9dc6e300e1cb")
  },
  new
  {
    CityId = new Guid("bc663570-a406-4f13-b590-21813a376c81"),
    Disabled = false,
    Name = "Durán",
    ProvinceId = new Guid("757ba0c1-d96b-4da3-b2a6-9dc6e300e1cb")
  },
  new
  {
    CityId = new Guid("a6f5135d-7413-471a-beff-ee1b4a5bd593"),
    Disabled = false,
    Name = "Ibarra",
    ProvinceId = new Guid("4c14f504-2bf8-4d25-ba70-e68b16b5a9f5")
  },
  new
  {
    CityId = new Guid("7dc1bf89-a940-4711-80e8-3a78db10e344"),
    Disabled = false,
    Name = "Otavalo",
    ProvinceId = new Guid("4c14f504-2bf8-4d25-ba70-e68b16b5a9f5")
  },
  new
  {
    CityId = new Guid("d272bfd1-784b-4157-aece-6dc8e1988ce6"),
    Disabled = false,
    Name = "Loja",
    ProvinceId = new Guid("598fd45a-994f-41d9-a403-9c194bc1f3f1")
  },
  new
  {
    CityId = new Guid("cce4259c-2960-4a47-a7c8-02cfb50f1e6c"),
    Disabled = false,
    Name = "Saraguro",
    ProvinceId = new Guid("598fd45a-994f-41d9-a403-9c194bc1f3f1")
  },
  new
  {
    CityId = new Guid("5db4bfce-e134-407b-a24c-0497f1539d27"),
    Disabled = false,
    Name = "Portoviejo",
    ProvinceId = new Guid("2fd56de4-45a9-462c-aa44-20d9125f0a13")
  },
  new
  {
    CityId = new Guid("fd4b07c0-84b1-48b8-9968-086577956884"),
    Disabled = false,
    Name = "Manta",
    ProvinceId = new Guid("2fd56de4-45a9-462c-aa44-20d9125f0a13")
  },
  new
  {
    CityId = new Guid("24207792-1fec-4e86-b5c1-adbeb8ffa401"),
    Disabled = false,
    Name = "Chone",
    ProvinceId = new Guid("2fd56de4-45a9-462c-aa44-20d9125f0a13")
  },
  new
  {
    CityId = new Guid("cc03cf35-b83b-4948-9e13-7d8c3b004ab6"),
    Disabled = false,
    Name = "Macas",
    ProvinceId = new Guid("c57330f1-e46e-4902-9de0-438dc52d1174")
  },
  new
  {
    CityId = new Guid("db87a032-d3d7-412b-8c3b-83d969f83887"),
    Disabled = false,
    Name = "Gualaquiza",
    ProvinceId = new Guid("c57330f1-e46e-4902-9de0-438dc52d1174")
  },
  new
  {
    CityId = new Guid("b3aea561-23a1-42b8-a7aa-7a8f756a1aca"),
    Disabled = false,
    Name = "Tena",
    ProvinceId = new Guid("c519d256-9f3d-4ad2-a462-c12970f4ee1a")
  },
  new
  {
    CityId = new Guid("75161f7c-d135-4a2e-b3db-4038dc437fac"),
    Disabled = false,
    Name = "Archidona",
    ProvinceId = new Guid("c519d256-9f3d-4ad2-a462-c12970f4ee1a")
  });
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.CountryModel", b =>
      {
        b.Property<Guid>("CountryId")
  .HasColumnType("uuid")
  .HasColumnName("ctr_country_id");

        b.Property<bool>("Disabled")
  .HasColumnType("boolean")
  .HasColumnName("ctr_disabled");

        b.Property<string>("Name")
  .IsRequired()
  .HasMaxLength(100)
  .HasColumnType("character varying(100)")
  .HasColumnName("ctr_name");

        b.HasKey("CountryId");

        b.HasIndex("Name")
  .IsUnique();

        b.ToTable("country");

        b.HasData(
  new
  {
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Colombia"
  },
  new
  {
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Ecuador"
  },
  new
  {
    CountryId = new Guid("a791d695-6892-40d2-9338-7ee3be9ad4a6"),
    Disabled = false,
    Name = "Venezuela"
  },
  new
  {
    CountryId = new Guid("4a37e802-b20b-4392-95e9-0410208d3334"),
    Disabled = false,
    Name = "Panamá"
  },
  new
  {
    CountryId = new Guid("70faee44-0378-414b-81f6-fcfb77bd13c6"),
    Disabled = false,
    Name = "Costa Rica"
  },
  new
  {
    CountryId = new Guid("8a8ea566-0db1-4359-9b6c-0070909a97a8"),
    Disabled = false,
    Name = "Nicaragua"
  },
  new
  {
    CountryId = new Guid("87a3d760-3df8-4fdd-aae6-292e31fdcb9e"),
    Disabled = false,
    Name = "Honduras"
  },
  new
  {
    CountryId = new Guid("70c0a9ab-4485-4a91-b148-f3f2fb41965c"),
    Disabled = false,
    Name = "Guatemala"
  },
  new
  {
    CountryId = new Guid("537cb3bc-59bc-44cf-971b-fe0135443813"),
    Disabled = false,
    Name = "El Salvador"
  },
  new
  {
    CountryId = new Guid("8147986e-e753-461b-97f4-d0f791efa836"),
    Disabled = false,
    Name = "Belize"
  },
  new
  {
    CountryId = new Guid("06f3a4b5-0716-4446-bfa5-0c7ad2d74d9b"),
    Disabled = false,
    Name = "México"
  },
  new
  {
    CountryId = new Guid("a32d1f48-9414-4201-9548-a8be5204fd36"),
    Disabled = false,
    Name = "Perú"
  },
  new
  {
    CountryId = new Guid("5ba23fc3-0a98-4033-b49b-372e87fa3f86"),
    Disabled = false,
    Name = "Chile"
  },
  new
  {
    CountryId = new Guid("1d8755cc-ecf0-4dbf-b089-535ca1cb02f2"),
    Disabled = false,
    Name = "Argentina"
  },
  new
  {
    CountryId = new Guid("bd091271-729a-4b81-8b06-6ed0c86e5d61"),
    Disabled = false,
    Name = "Brasil"
  },
  new
  {
    CountryId = new Guid("e38f25ee-e63a-4938-9cb2-b52674b4bbc1"),
    Disabled = false,
    Name = "Paraguay"
  },
  new
  {
    CountryId = new Guid("c54255f8-4772-4bbf-9d54-05258d5a9b76"),
    Disabled = false,
    Name = "Uruguay"
  },
  new
  {
    CountryId = new Guid("b5c445d1-7a6a-4441-8f81-540de5a1a839"),
    Disabled = false,
    Name = "Bolivia"
  });
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.ProfessionalModel", b =>
      {
        b.Property<Guid>("ProfessionalId")
  .HasColumnType("uuid")
  .HasColumnName("prf_professional_id");

        b.Property<DateTime>("CreatedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("created_at");

        b.Property<DateTime?>("DeletedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("deleted_at");

        b.Property<bool>("Disabled")
  .HasColumnType("boolean")
  .HasColumnName("prf_disabled");

        b.Property<string>("Email")
  .IsRequired()
  .HasMaxLength(100)
  .HasColumnType("character varying(100)")
  .HasColumnName("prf_email");

        b.Property<string>("Name")
  .IsRequired()
  .HasMaxLength(100)
  .HasColumnType("character varying(100)")
  .HasColumnName("prf_name");

        b.Property<DateTime?>("UpdatedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("updated_at");

        b.HasKey("ProfessionalId");

        b.HasIndex("Email")
  .IsUnique();

        b.ToTable("professional");

        b.HasData(
  new
  {
    ProfessionalId = new Guid("a11352cb-668a-4a76-8a6f-6771162d1671"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9392),
    Disabled = false,
    Email = "juanperez@gmail.com",
    Name = "Juan Pérez"
  },
  new
  {
    ProfessionalId = new Guid("66bf83fe-0fe4-40c6-9c43-1eedb0d0443f"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9398),
    Disabled = false,
    Email = "mariagarcia@gmail.com",
    Name = "María García"
  },
  new
  {
    ProfessionalId = new Guid("90b8d862-17aa-4d18-a100-3523123c77ab"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9402),
    Disabled = false,
    Email = "pedrolopez@gmail.com",
    Name = "Pedro López"
  },
  new
  {
    ProfessionalId = new Guid("c276d7e0-8bd0-426d-bda4-8bf2ce8ddaa3"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9405),
    Disabled = false,
    Email = "anasanchez@gmail.com",
    Name = "Ana Sánchez"
  },
  new
  {
    ProfessionalId = new Guid("7d978578-8c6c-4870-8095-baf7fc1d2853"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9409),
    Disabled = false,
    Email = "carlosrodriguez@gmail.com",
    Name = "Carlos Rodríguez"
  },
  new
  {
    ProfessionalId = new Guid("602b3199-6a2a-4918-bb85-4636d9c29be5"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9414),
    Disabled = false,
    Email = "isabelmartinez@gmail.com",
    Name = "Isabel Martínez"
  },
  new
  {
    ProfessionalId = new Guid("40569c7c-7287-4806-9de6-3f5fc3eaaf22"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9417),
    Disabled = false,
    Email = "diegogomez@gmail.com",
    Name = "Diego Gómez"
  },
  new
  {
    ProfessionalId = new Guid("9ae32427-a2b9-4f7b-bca0-7e46817a3115"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9421),
    Disabled = false,
    Email = "sandramoreno@gmail.com",
    Name = "Sandra Moreno"
  },
  new
  {
    ProfessionalId = new Guid("11f85ce9-fbbe-4710-a91b-02ed4ed1097b"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9425),
    Disabled = false,
    Email = "andresfernandez@gmail.com",
    Name = "Andrés Fernández"
  },
  new
  {
    ProfessionalId = new Guid("d64bd55a-563c-4874-a6da-ee19b30a18be"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9430),
    Disabled = false,
    Email = "lauragonzalez@gmail.com",
    Name = "Laura González"
  },
  new
  {
    ProfessionalId = new Guid("56b3e3f3-537f-416f-98b1-4ecb719c4489"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9433),
    Disabled = false,
    Email = "javiermunoz@gmail.com",
    Name = "Javier Muñoz"
  },
  new
  {
    ProfessionalId = new Guid("ca92888f-d3a0-4e41-b4e9-484d2393b19c"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9437),
    Disabled = false,
    Email = "patriciablanco@gmail.com",
    Name = "Patricia Blanco"
  },
  new
  {
    ProfessionalId = new Guid("3bffc7d4-6676-44a5-9dac-d1d55be1f026"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9441),
    Disabled = false,
    Email = "josegutierrez@gmail.com",
    Name = "José Gutiérrez"
  },
  new
  {
    ProfessionalId = new Guid("6196f2a8-30f6-42d3-a4a4-be5bec48a451"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9444),
    Disabled = false,
    Email = "aliciaruis@gmail.com",
    Name = "Alicia Ruiz"
  },
  new
  {
    ProfessionalId = new Guid("b8dbba25-43e4-4f67-b905-4fc32f9bf143"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9448),
    Disabled = false,
    Email = "luisvazquez@gmail.com",
    Name = "Luis Vázquez"
  });
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.ProvinceModel", b =>
      {
        b.Property<Guid>("ProvinceId")
  .HasColumnType("uuid")
  .HasColumnName("prv_province_id");

        b.Property<Guid>("CountryId")
  .HasColumnType("uuid")
  .HasColumnName("ctr_country_id");

        b.Property<bool>("Disabled")
  .HasColumnType("boolean")
  .HasColumnName("prv_disabled");

        b.Property<string>("Name")
  .IsRequired()
  .HasMaxLength(100)
  .HasColumnType("character varying(100)")
  .HasColumnName("prv_name");

        b.HasKey("ProvinceId");

        b.HasIndex("CountryId");

        b.HasIndex("Name", "CountryId")
  .IsUnique();

        b.ToTable("province");

        b.HasData(
  new
  {
    ProvinceId = new Guid("fb75bdf5-a843-4761-9aee-2b1200be26d5"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Amazonas"
  },
  new
  {
    ProvinceId = new Guid("cd7f27b3-293b-4f44-8136-a466f8ff9525"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Antioquia"
  },
  new
  {
    ProvinceId = new Guid("71860591-cf14-48a9-a06f-c68eccb2d8c1"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Arauca"
  },
  new
  {
    ProvinceId = new Guid("286cd1ec-ee8f-47e6-b17e-88958107298b"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Atlántico"
  },
  new
  {
    ProvinceId = new Guid("c77fbe3f-af07-45c7-ad0d-b594760cb97c"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Bolívar"
  },
  new
  {
    ProvinceId = new Guid("40744b42-e290-4596-90f5-b7a8b140236b"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Boyacá"
  },
  new
  {
    ProvinceId = new Guid("ed5f6e76-e8fa-4e0e-9bbf-9ad362dea113"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Caldas"
  },
  new
  {
    ProvinceId = new Guid("d7450556-7eba-4cf3-8461-318e8b6f7e53"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Caquetá"
  },
  new
  {
    ProvinceId = new Guid("4e4cdf78-9ff6-4ea5-bfbd-c37bad442e85"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Casanare"
  },
  new
  {
    ProvinceId = new Guid("3fc8c2e7-d2c3-4a7e-88e5-dd9e0a62e0e6"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Cauca"
  },
  new
  {
    ProvinceId = new Guid("4cfb18bd-fe66-45d8-afcc-edc70dc78d1b"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Cesar"
  },
  new
  {
    ProvinceId = new Guid("31fafa3c-8545-48fc-a248-c70016be95fa"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Chocó"
  },
  new
  {
    ProvinceId = new Guid("b87f01bd-31ee-42aa-b985-c807c30dd9cb"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Córdoba"
  },
  new
  {
    ProvinceId = new Guid("d3427d27-320e-4808-8757-437c856d18ac"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Cundinamarca"
  },
  new
  {
    ProvinceId = new Guid("0ec08a72-79fc-4b7e-865c-db1951bfc5d0"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Guainía"
  },
  new
  {
    ProvinceId = new Guid("db82d3b8-24d5-4ebe-8814-528a8b0948f2"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Guaviare"
  },
  new
  {
    ProvinceId = new Guid("94d89b69-c4c7-4606-b059-63c1a9b656d5"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Huila"
  },
  new
  {
    ProvinceId = new Guid("c6818890-d8f6-48b5-9cbd-9e12579d6d1a"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "La Guajira"
  },
  new
  {
    ProvinceId = new Guid("77dc62b7-1b37-4316-bc0f-67901e36cbf3"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Magdalena"
  },
  new
  {
    ProvinceId = new Guid("b9ac4bcb-a6e2-494f-a7d8-3500576e5d75"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Meta"
  },
  new
  {
    ProvinceId = new Guid("06189287-3dcb-49f0-90c0-fcd95b95e327"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Nariño"
  },
  new
  {
    ProvinceId = new Guid("2cfcb757-0670-4bb6-99d6-5e9922e7326b"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Norte de Santander"
  },
  new
  {
    ProvinceId = new Guid("0609ac6f-5a8c-4cdb-ba77-a2c4e468ae95"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Putumayo"
  },
  new
  {
    ProvinceId = new Guid("aa85be1f-abe2-4751-8da7-38a2b930b527"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Quindío"
  },
  new
  {
    ProvinceId = new Guid("1ba2474d-58d2-4e82-8e59-cae097423d56"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Risaralda"
  },
  new
  {
    ProvinceId = new Guid("be362bcd-e59d-4ea3-bf20-cd3bcc17c204"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "San Andrés y Providencia"
  },
  new
  {
    ProvinceId = new Guid("8f8a595a-c58d-4ee8-a148-40cbb003c03f"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Santander"
  },
  new
  {
    ProvinceId = new Guid("2182384c-72d0-4cd8-8479-168b185cb08a"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Sucre"
  },
  new
  {
    ProvinceId = new Guid("bbe7ef02-cfa6-4bd7-bf26-4246282e13b2"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Tolima"
  },
  new
  {
    ProvinceId = new Guid("1b586621-1fef-424e-81fa-bec0fb285679"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Valle del Cauca"
  },
  new
  {
    ProvinceId = new Guid("b8a17803-d01b-4142-96b8-5d7c8b2d1958"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Vaupés"
  },
  new
  {
    ProvinceId = new Guid("289c8325-899d-4e9c-bb26-da8a2fbd68b2"),
    CountryId = new Guid("dffc9b8f-2244-430a-a9c5-1e241427b7db"),
    Disabled = false,
    Name = "Vichada"
  },
  new
  {
    ProvinceId = new Guid("e05ddb61-7b4a-4fb0-85f7-fcd8f7c0cb55"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Azuay"
  },
  new
  {
    ProvinceId = new Guid("fedf041f-4b2b-485b-8d33-685e877b6576"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Bolívar"
  },
  new
  {
    ProvinceId = new Guid("d100d89d-0c05-4131-b940-a850873b0718"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Cañar"
  },
  new
  {
    ProvinceId = new Guid("3d892b15-f5ae-4b61-bcca-5168bf56748d"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Carchi"
  },
  new
  {
    ProvinceId = new Guid("28daa4f8-3dc4-4801-aa1b-057acb3b6f18"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Chimborazo"
  },
  new
  {
    ProvinceId = new Guid("00997a7b-f986-47c5-a2d4-62b2993797b7"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Cotopaxi"
  },
  new
  {
    ProvinceId = new Guid("220ee83b-77ef-4ae1-a0aa-b7d5d2eabc9d"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "El Oro"
  },
  new
  {
    ProvinceId = new Guid("8c028c6e-2626-4ade-b031-a1ea14c56ffc"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Esmeraldas"
  },
  new
  {
    ProvinceId = new Guid("5ddb40a0-df7b-44fd-9596-676db9a50bd4"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Galápagos"
  },
  new
  {
    ProvinceId = new Guid("757ba0c1-d96b-4da3-b2a6-9dc6e300e1cb"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Guayas"
  },
  new
  {
    ProvinceId = new Guid("4c14f504-2bf8-4d25-ba70-e68b16b5a9f5"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Imbabura"
  },
  new
  {
    ProvinceId = new Guid("598fd45a-994f-41d9-a403-9c194bc1f3f1"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Loja"
  },
  new
  {
    ProvinceId = new Guid("2fd56de4-45a9-462c-aa44-20d9125f0a13"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Manabí"
  },
  new
  {
    ProvinceId = new Guid("c57330f1-e46e-4902-9de0-438dc52d1174"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Morona Santiago"
  },
  new
  {
    ProvinceId = new Guid("c519d256-9f3d-4ad2-a462-c12970f4ee1a"),
    CountryId = new Guid("0dae59d5-223f-46a4-9bda-7c20548c3d65"),
    Disabled = false,
    Name = "Napo"
  });
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.RoleModel", b =>
      {
        b.Property<Guid>("RoleId")
  .HasColumnType("uuid")
  .HasColumnName("rol_role_id");

        b.Property<DateTime>("CreatedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("created_at");

        b.Property<DateTime?>("DeletedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("deleted_at");

        b.Property<string>("Description")
  .HasMaxLength(1024)
  .HasColumnType("character varying(1024)")
  .HasColumnName("rol_description");

        b.Property<bool>("Disabled")
  .HasColumnType("boolean")
  .HasColumnName("rol_disabled");

        b.Property<string>("Name")
  .IsRequired()
  .HasMaxLength(100)
  .HasColumnType("character varying(100)")
  .HasColumnName("rol_name");

        b.Property<DateTime?>("UpdatedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("updated_at");

        b.HasKey("RoleId");

        b.HasIndex("Name")
  .IsUnique();

        b.ToTable("role");

        b.HasData(
  new
  {
    RoleId = new Guid("90b0061e-e2d0-493e-a012-a322bd5dd9b2"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9209),
    Disabled = false,
    Name = "Developer"
  },
  new
  {
    RoleId = new Guid("125b4665-06c6-4dc5-ba06-94c4b15d335b"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9215),
    Disabled = false,
    Name = "Designer"
  },
  new
  {
    RoleId = new Guid("b1cfc032-8a93-4ac9-9d23-efbc808e92ec"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9220),
    Disabled = false,
    Name = "Manager"
  },
  new
  {
    RoleId = new Guid("e65033b0-0782-4253-a07d-4094c228ca12"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9223),
    Disabled = false,
    Name = "QA"
  },
  new
  {
    RoleId = new Guid("9ba9f7de-92af-4c60-a028-0200dd57a71a"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9227),
    Disabled = false,
    Name = "DevOps"
  },
  new
  {
    RoleId = new Guid("a897d330-3015-4106-a236-c0e4ea05e889"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9232),
    Disabled = false,
    Name = "Data Scientist"
  },
  new
  {
    RoleId = new Guid("8976be6f-69af-48b9-80c9-3b6b3bc288b0"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9235),
    Disabled = false,
    Name = "UX/UI Designer"
  },
  new
  {
    RoleId = new Guid("6ede8e21-28e2-4085-acac-c356d22481d0"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9239),
    Disabled = false,
    Name = "Product Owner"
  },
  new
  {
    RoleId = new Guid("a1373243-9250-424b-8673-74d7c648ac1c"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9242),
    Disabled = false,
    Name = "Scrum Master"
  },
  new
  {
    RoleId = new Guid("cecc1624-39fd-4371-8d00-b68281f8f0b9"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9247),
    Disabled = false,
    Name = "Architect"
  },
  new
  {
    RoleId = new Guid("7eb147e9-3f77-4259-a1aa-4f11f24daa8f"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9250),
    Disabled = false,
    Name = "Lead Developer"
  },
  new
  {
    RoleId = new Guid("2685c56a-89bc-4377-8c25-6c72ffca41d3"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9254),
    Disabled = false,
    Name = "Lead Designer"
  });
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.SkillModel", b =>
      {
        b.Property<Guid>("SkillId")
  .HasColumnType("uuid")
  .HasColumnName("skl_skill_id");

        b.Property<DateTime>("CreatedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("created_at");

        b.Property<DateTime?>("DeletedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("deleted_at");

        b.Property<bool>("Disabled")
  .HasColumnType("boolean")
  .HasColumnName("skl_disabled");

        b.Property<string>("Name")
  .IsRequired()
  .HasMaxLength(20)
  .HasColumnType("character varying(20)")
  .HasColumnName("skl_name");

        b.Property<DateTime?>("UpdatedAt")
  .HasColumnType("timestamp with time zone")
  .HasColumnName("updated_at");

        b.HasKey("SkillId");

        b.HasIndex("Name")
  .IsUnique();

        b.ToTable("skill");

        b.HasData(
  new
  {
    SkillId = new Guid("6ce99075-2599-470d-9333-a9cfc64b787a"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9277),
    Disabled = false,
    Name = "C#"
  },
  new
  {
    SkillId = new Guid("a2254506-31b3-4fce-b067-eb57ee887b7b"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9283),
    Disabled = false,
    Name = "Java"
  },
  new
  {
    SkillId = new Guid("0d8db036-74cb-4018-9c91-0e1e917c5309"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9287),
    Disabled = false,
    Name = "Python"
  },
  new
  {
    SkillId = new Guid("e95ed72b-2c1c-4a7d-97de-b07afecc8966"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9290),
    Disabled = false,
    Name = "JavaScript"
  },
  new
  {
    SkillId = new Guid("3aabd46b-013d-4102-9f2d-6dcdf637c5f3"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9294),
    Disabled = false,
    Name = "TypeScript"
  },
  new
  {
    SkillId = new Guid("0951550f-2815-4ae9-aadc-27e93d6df349"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9298),
    Disabled = false,
    Name = "HTML"
  },
  new
  {
    SkillId = new Guid("dc5e5118-a46b-487d-b927-21d0eb5b4e70"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9301),
    Disabled = false,
    Name = "CSS"
  },
  new
  {
    SkillId = new Guid("8fb0ed9b-372f-4920-8790-ebd86dccd974"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9305),
    Disabled = false,
    Name = "SQL"
  },
  new
  {
    SkillId = new Guid("f2335f11-bfe2-486d-a8bd-3de0f0e34225"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9308),
    Disabled = false,
    Name = "NoSQL"
  },
  new
  {
    SkillId = new Guid("04b9de11-163e-4b34-a77e-f3bab284afc2"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9312),
    Disabled = false,
    Name = "Angular"
  },
  new
  {
    SkillId = new Guid("5c729964-1d07-41e8-927c-b0fedfaac84f"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9318),
    Disabled = false,
    Name = "React"
  },
  new
  {
    SkillId = new Guid("2c3dc0f5-ea58-4f67-a919-cc2cc72f0983"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9319),
    Disabled = false,
    Name = "Vue"
  },
  new
  {
    SkillId = new Guid("c1622bbe-1607-48fa-9d5c-3fc79a47ff2b"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9322),
    Disabled = false,
    Name = "Node.js"
  },
  new
  {
    SkillId = new Guid("2f6f0cf5-68f3-4765-bea1-27286ab9f878"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9354),
    Disabled = false,
    Name = "Spring Boot"
  },
  new
  {
    SkillId = new Guid("8ea4c051-e77e-499d-8025-c9e91478831d"),
    CreatedAt = new DateTime(2024, 4, 28, 10, 40, 47, 2, DateTimeKind.Utc).AddTicks(9358),
    Disabled = false,
    Name = "Hibernate"
  });
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.CityModel", b =>
      {
        b.HasOne("Profiles.Infrastructure.Persistence.Models.ProvinceModel", "Province")
  .WithMany("Cities")
  .HasForeignKey("ProvinceId")
  .OnDelete(DeleteBehavior.Restrict)
  .IsRequired();

        b.Navigation("Province");
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.ProvinceModel", b =>
      {
        b.HasOne("Profiles.Infrastructure.Persistence.Models.CountryModel", "Country")
  .WithMany("Provinces")
  .HasForeignKey("CountryId")
  .OnDelete(DeleteBehavior.Restrict)
  .IsRequired();

        b.Navigation("Country");
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.CountryModel", b =>
      {
        b.Navigation("Provinces");
      });

      modelBuilder.Entity("Profiles.Infrastructure.Persistence.Models.ProvinceModel", b =>
      {
        b.Navigation("Cities");
      });
#pragma warning restore 612, 618
    }
  }
}
