﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OutOfOffice.Identity;

#nullable disable

namespace OutOfOffice.Identity.Migrations
{
    [DbContext(typeof(RepositoryIdentityDbContext))]
    partial class RepositoryIdentityDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "335308de-a56c-4a30-aea9-8702fdc4bc2b",
                            Name = "Employee",
                            NormalizedName = "EMPLOYEE"
                        },
                        new
                        {
                            Id = "32884cd1-aaed-4131-bf49-f98f8c44d882",
                            Name = "HR Manager",
                            NormalizedName = "HR MANAGER"
                        },
                        new
                        {
                            Id = "78915281-09ad-4fbc-befc-61b155f3ba3e",
                            Name = "Project Manager",
                            NormalizedName = "PROJECT MANAGER"
                        },
                        new
                        {
                            Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            RoleId = "335308de-a56c-4a30-aea9-8702fdc4bc2b"
                        },
                        new
                        {
                            UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            RoleId = "32884cd1-aaed-4131-bf49-f98f8c44d882"
                        },
                        new
                        {
                            UserId = "7f9a84bf-6557-48e5-ba2e-7c7276751a39",
                            RoleId = "78915281-09ad-4fbc-befc-61b155f3ba3e"
                        },
                        new
                        {
                            UserId = "026e9845-6dcd-4ff1-a8ba-74a889d7cc85",
                            RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OutOfOffice.Application.Models.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("longtext");

                    b.Property<string>("RefreshTokenExpiryTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "417e0bb3-9a66-43c9-b99c-09b534888a29",
                            Email = "employee@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "EmployeeFN",
                            LastName = "EmployeeLN",
                            LockoutEnabled = false,
                            NormalizedEmail = "EMPLOYEE@LOCALHOST.COM",
                            NormalizedUserName = "EMPLOYEETEST",
                            PasswordHash = "AQAAAAIAAYagAAAAEED0UZ7V4DAmr2c2optLmRLyV4Oz8TdtuaNsw4eFjo1ZzG82yB5kc2gFIs9U6CoY6g==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = "0001-01-01 00:00:00",
                            SecurityStamp = "575f5cc4-a475-49c5-b014-4dad5d69b6a5",
                            TwoFactorEnabled = false,
                            UserName = "EmployeeTEST"
                        },
                        new
                        {
                            Id = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e60e8955-ea68-4167-91aa-c35b3f5f57c3",
                            Email = "hrmanager@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "HRManagerFN",
                            LastName = "HRManagerLN",
                            LockoutEnabled = false,
                            NormalizedEmail = "HRMANAGER@LOCALHOST.COM",
                            NormalizedUserName = "HRMANAGERTEST",
                            PasswordHash = "AQAAAAIAAYagAAAAEF5oORfWHBjGZFw/fsJwy/LRojwvx46o5c9MfX9vBRopD0fcWrByos64+dR/gKiEeA==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = "0001-01-01 00:00:00",
                            SecurityStamp = "08f6acfd-1d58-4399-981f-afbfb251add9",
                            TwoFactorEnabled = false,
                            UserName = "HRManagerTEST"
                        },
                        new
                        {
                            Id = "7f9a84bf-6557-48e5-ba2e-7c7276751a39",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "215e6a9d-0862-420a-b5f8-48571b5f23f0",
                            Email = "projectmanager@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "ProjectManagerFN",
                            LastName = "ProjectManagerLN",
                            LockoutEnabled = false,
                            NormalizedEmail = "PROJECTMANAGER@LOCALHOST.COM",
                            NormalizedUserName = "PROJECTMANAGERTEST",
                            PasswordHash = "AQAAAAIAAYagAAAAEI+4kOf/C/5oMiqZRq8Vd4KQ1x9x5Jw4DiVJDtuHXs8E3HcXpOljOP8vlDiAwtYjEg==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = "0001-01-01 00:00:00",
                            SecurityStamp = "419e045b-c72b-4c8a-a846-5b7b955515ca",
                            TwoFactorEnabled = false,
                            UserName = "ProjectManagerTEST"
                        },
                        new
                        {
                            Id = "026e9845-6dcd-4ff1-a8ba-74a889d7cc85",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fc533e82-2262-4560-90a0-cc4c26a0a27a",
                            Email = "administrator@localhost.com",
                            EmailConfirmed = true,
                            FirstName = "AdministratorFN",
                            LastName = "AdministratorLN",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMINISTRATOR@LOCALHOST.COM",
                            NormalizedUserName = "ADMINISTRATORTEST",
                            PasswordHash = "AQAAAAIAAYagAAAAEIOUL2Hz/G8PDbM2m0+fqrCc3Pzsaa+ktPY9K7kZxCqMd+W3t0om15Ih6p8pF6ENfg==",
                            PhoneNumberConfirmed = false,
                            RefreshTokenExpiryTime = "0001-01-01 00:00:00",
                            SecurityStamp = "1a429a47-c768-4e39-a89d-fa75b74a2601",
                            TwoFactorEnabled = false,
                            UserName = "AdministratorTEST"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("OutOfOffice.Application.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("OutOfOffice.Application.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OutOfOffice.Application.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("OutOfOffice.Application.Models.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
