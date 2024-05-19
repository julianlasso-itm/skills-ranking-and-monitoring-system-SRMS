﻿// <auto-generated />
using System;
using AccessControl.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AccessControl.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240508044441_FixUserTable")]
    partial class FixUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AccessControl.Infrastructure.Persistence.Models.RoleModel", b =>
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

                    b.HasIndex("Name", "DeletedAt")
                        .IsUnique();

                    b.ToTable("role");

                    b.HasData(
                        new
                        {
                            RoleId = new Guid("1933240c-c76c-4c5a-9772-d3bdbde9b72c"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2226),
                            Description = "Admin role",
                            Disabled = false,
                            Name = "Admin"
                        },
                        new
                        {
                            RoleId = new Guid("137bcadf-79bb-47f4-8622-e7381c7664ae"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2232),
                            Description = "User role",
                            Disabled = false,
                            Name = "User"
                        },
                        new
                        {
                            RoleId = new Guid("5dc96435-b54d-4c31-bada-9ca912819855"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2236),
                            Description = "Guest role",
                            Disabled = false,
                            Name = "Guest"
                        },
                        new
                        {
                            RoleId = new Guid("22eef1fd-c4d5-4802-bf56-8d9b68beb659"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2241),
                            Description = "SuperAdmin role",
                            Disabled = false,
                            Name = "SuperAdmin"
                        },
                        new
                        {
                            RoleId = new Guid("7fa1a171-626f-4f4f-845c-583eeaaa4e66"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2245),
                            Description = "Moderator role",
                            Disabled = false,
                            Name = "Moderator"
                        },
                        new
                        {
                            RoleId = new Guid("eb1676ef-5e69-4458-965f-d4abf5d18eb3"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2250),
                            Description = "Editor role",
                            Disabled = false,
                            Name = "Editor"
                        },
                        new
                        {
                            RoleId = new Guid("5a93c3a1-c1cb-4c3f-b339-4c9c3472dc2c"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2254),
                            Description = "Author role",
                            Disabled = false,
                            Name = "Author"
                        },
                        new
                        {
                            RoleId = new Guid("3f5ee3d4-b800-415f-87b5-c13484192806"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2258),
                            Description = "Contributor role",
                            Disabled = false,
                            Name = "Contributor"
                        },
                        new
                        {
                            RoleId = new Guid("40cde1ee-f690-48ce-bf5b-450976178258"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2262),
                            Description = "Subscriber role",
                            Disabled = false,
                            Name = "Subscriber"
                        },
                        new
                        {
                            RoleId = new Guid("4e032af9-f029-402a-96ea-b425b3079a2f"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2267),
                            Description = "Member role",
                            Disabled = false,
                            Name = "Member"
                        },
                        new
                        {
                            RoleId = new Guid("2df4d5ba-940b-40f0-ac17-7b0217ec4417"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2271),
                            Description = "Customer role",
                            Disabled = false,
                            Name = "Customer"
                        },
                        new
                        {
                            RoleId = new Guid("44243581-3a22-4902-8604-37b6d39a2f42"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2275),
                            Description = "Client role",
                            Disabled = false,
                            Name = "Client"
                        },
                        new
                        {
                            RoleId = new Guid("ceafeaa6-0c28-43d4-80e1-4735f71fd75c"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2279),
                            Description = "Viewer role",
                            Disabled = false,
                            Name = "Viewer"
                        },
                        new
                        {
                            RoleId = new Guid("62014bb1-1cd9-44e6-8903-f8e27dd17458"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2283),
                            Description = "Tester role",
                            Disabled = false,
                            Name = "Tester"
                        },
                        new
                        {
                            RoleId = new Guid("39828fe2-634d-4e15-970d-892edfbf4d99"),
                            CreatedAt = new DateTime(2024, 5, 8, 4, 44, 41, 317, DateTimeKind.Utc).AddTicks(2287),
                            Description = "Developer role",
                            Disabled = false,
                            Name = "Developer"
                        });
                });

            modelBuilder.Entity("AccessControl.Infrastructure.Persistence.Models.UserModel", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("usr_user_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("created_at");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("deleted_at");

                    b.Property<bool>("Disabled")
                        .HasColumnType("boolean")
                        .HasColumnName("usr_disabled");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("usr_email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("usr_name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnName("usr_password");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("usr_photo");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("updated_at");

                    b.HasKey("UserId");

                    b.HasIndex("Email", "DeletedAt")
                        .IsUnique();

                    b.HasIndex("Email", "Password");

                    b.ToTable("user");
                });

            modelBuilder.Entity("AccessControl.Infrastructure.Persistence.Models.UserPerRoleModel", b =>
                {
                    b.Property<Guid>("UserPerRoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("upr_id");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("upr_role_id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("upr_user_id");

                    b.HasKey("UserPerRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId", "RoleId")
                        .IsUnique();

                    b.ToTable("user_per_role");
                });

            modelBuilder.Entity("AccessControl.Infrastructure.Persistence.Models.UserPerRoleModel", b =>
                {
                    b.HasOne("AccessControl.Infrastructure.Persistence.Models.RoleModel", "Role")
                        .WithMany("UserPerRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AccessControl.Infrastructure.Persistence.Models.UserModel", "User")
                        .WithMany("UserPerRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AccessControl.Infrastructure.Persistence.Models.RoleModel", b =>
                {
                    b.Navigation("UserPerRoles");
                });

            modelBuilder.Entity("AccessControl.Infrastructure.Persistence.Models.UserModel", b =>
                {
                    b.Navigation("UserPerRoles");
                });
#pragma warning restore 612, 618
        }
    }
}