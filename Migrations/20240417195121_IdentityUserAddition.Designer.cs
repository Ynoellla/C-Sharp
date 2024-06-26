﻿// <auto-generated />
using System;
using CPT231_Assignment06_LeviNoell_Baba.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CPT231_Assignment06_LeviNoell_Baba.Migrations
{
    [DbContext(typeof(NoellBabaContext))]
    [Migration("20240417195121_IdentityUserAddition")]
    partial class IdentityUserAddition
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CPT231_Assignment06_LeviNoell_Baba.Models.Magic", b =>
                {
                    b.Property<int>("MagicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MagicId"));

                    b.Property<string>("CardColor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CardType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsPermanent")
                        .HasColumnType("bit");

                    b.Property<int>("ManaCost")
                        .HasColumnType("int");

                    b.Property<int>("Power")
                        .HasColumnType("int");

                    b.Property<int>("Toughness")
                        .HasColumnType("int");

                    b.HasKey("MagicId");

                    b.ToTable("Magics");

                    b.HasData(
                        new
                        {
                            MagicId = 1,
                            CardColor = "Colorless",
                            CardName = "Roaming Throne",
                            CardType = "Artifact Creature - Golem",
                            IsPermanent = true,
                            ManaCost = 4,
                            Power = 4,
                            Toughness = 4
                        },
                        new
                        {
                            MagicId = 2,
                            CardColor = "Red",
                            CardName = "Hunting Velociraptor",
                            CardType = "Creature - Dinosaur",
                            IsPermanent = true,
                            ManaCost = 3,
                            Power = 3,
                            Toughness = 2
                        },
                        new
                        {
                            MagicId = 3,
                            CardColor = "Blue",
                            CardName = "Tishana's Tidebinder",
                            CardType = "Creature - Merfolk Wizard",
                            IsPermanent = true,
                            ManaCost = 3,
                            Power = 3,
                            Toughness = 2
                        },
                        new
                        {
                            MagicId = 4,
                            CardColor = "Red, Green",
                            CardName = "Owen Grady, Raptor Trainer",
                            CardType = "Legenday Creature - Human Soldier Scientist",
                            IsPermanent = true,
                            ManaCost = 3,
                            Power = 3,
                            Toughness = 2
                        },
                        new
                        {
                            MagicId = 5,
                            CardColor = "Colorless",
                            CardName = "Sunken Citadel",
                            CardType = "Land - Cave",
                            IsPermanent = true,
                            ManaCost = 0,
                            Power = 0,
                            Toughness = 0
                        },
                        new
                        {
                            MagicId = 6,
                            CardColor = "Colorless",
                            CardName = "Reliquary Tower",
                            CardType = "Land",
                            IsPermanent = true,
                            ManaCost = 0,
                            Power = 0,
                            Toughness = 0
                        },
                        new
                        {
                            MagicId = 7,
                            CardColor = "Colorless",
                            CardName = "Myriad Landscape",
                            CardType = "Land",
                            IsPermanent = true,
                            ManaCost = 0,
                            Power = 0,
                            Toughness = 0
                        },
                        new
                        {
                            MagicId = 8,
                            CardColor = "Colorless",
                            CardName = "Evolving Wilds",
                            CardType = "Land",
                            IsPermanent = true,
                            ManaCost = 0,
                            Power = 0,
                            Toughness = 0
                        },
                        new
                        {
                            MagicId = 9,
                            CardColor = "Colorless",
                            CardName = "Hunter's Blowgun",
                            CardType = "Artifact - Equipment",
                            IsPermanent = true,
                            ManaCost = 1,
                            Power = 0,
                            Toughness = 0
                        },
                        new
                        {
                            MagicId = 10,
                            CardColor = "Green",
                            CardName = "Walk with the Ancestors",
                            CardType = "Sorcery",
                            IsPermanent = false,
                            ManaCost = 5,
                            Power = 0,
                            Toughness = 0
                        },
                        new
                        {
                            MagicId = 11,
                            CardColor = "Red",
                            CardName = "Triumphant Chomp",
                            CardType = "Sorcery",
                            IsPermanent = false,
                            ManaCost = 1,
                            Power = 0,
                            Toughness = 0
                        },
                        new
                        {
                            MagicId = 12,
                            CardColor = "Green",
                            CardName = "Twists and Turns",
                            CardType = "Enchantment",
                            IsPermanent = true,
                            ManaCost = 1,
                            Power = 0,
                            Toughness = 0
                        });
                });

            modelBuilder.Entity("CPT231_Assignment06_LeviNoell_Baba.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
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
                    b.HasOne("CPT231_Assignment06_LeviNoell_Baba.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CPT231_Assignment06_LeviNoell_Baba.User", null)
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

                    b.HasOne("CPT231_Assignment06_LeviNoell_Baba.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CPT231_Assignment06_LeviNoell_Baba.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
