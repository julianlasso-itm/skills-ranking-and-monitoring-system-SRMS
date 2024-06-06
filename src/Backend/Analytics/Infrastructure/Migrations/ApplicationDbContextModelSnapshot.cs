﻿// <auto-generated />
using System;
using Analytics.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Analytics.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Analytics.Infrastructure.Persistence.Models.LevelModel", b =>
                {
                    b.Property<Guid>("LevelId")
                        .HasColumnType("uuid")
                        .HasColumnName("rol_level_id");

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

                    b.HasKey("LevelId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("level");

                    b.HasData(
                        new
                        {
                            LevelId = new Guid("2fc96373-291c-4d14-9c39-c31c98661cd1"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3708),
                            Disabled = false,
                            Name = "Backend"
                        },
                        new
                        {
                            LevelId = new Guid("155eecee-87b0-46fc-aa04-bf1404406770"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3716),
                            Disabled = false,
                            Name = "Frontend"
                        },
                        new
                        {
                            LevelId = new Guid("bb020e08-19d8-406d-a71d-ec8a2fdb15b7"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3721),
                            Disabled = false,
                            Name = "Fullstack"
                        },
                        new
                        {
                            LevelId = new Guid("a143be47-5cf2-41dc-9072-2f7cb1a66bd5"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3724),
                            Disabled = false,
                            Name = "DevOps"
                        },
                        new
                        {
                            LevelId = new Guid("b3d342d9-8c40-45f5-bb7f-9a51fd20a87b"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3728),
                            Disabled = false,
                            Name = "QA"
                        },
                        new
                        {
                            LevelId = new Guid("b2b3c42b-b2a5-4086-8eff-7cc483bb40b9"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3734),
                            Disabled = false,
                            Name = "UX/UI"
                        },
                        new
                        {
                            LevelId = new Guid("028de8ac-4c8f-4a94-aa66-a844e42d12cc"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3737),
                            Disabled = false,
                            Name = "DataScience"
                        },
                        new
                        {
                            LevelId = new Guid("5e55880c-6971-4d37-b8dd-47b198849807"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3741),
                            Disabled = false,
                            Name = "Cybersecurity"
                        },
                        new
                        {
                            LevelId = new Guid("74746ada-4c24-4cc5-bf9c-e009e6dbc4ce"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3746),
                            Disabled = false,
                            Name = "Product"
                        },
                        new
                        {
                            LevelId = new Guid("6677c7e6-5e60-4146-93bb-a6d86d28b67b"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3751),
                            Disabled = false,
                            Name = "Project"
                        },
                        new
                        {
                            LevelId = new Guid("3d9ccb29-7a60-4ac1-aae2-9228e2ce9715"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3755),
                            Disabled = false,
                            Name = "Management"
                        },
                        new
                        {
                            LevelId = new Guid("71ca0bc8-52f7-42e1-8541-88d8b71a5a19"),
                            CreatedAt = new DateTime(2024, 6, 6, 1, 12, 56, 625, DateTimeKind.Utc).AddTicks(3759),
                            Disabled = false,
                            Name = "Other"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
