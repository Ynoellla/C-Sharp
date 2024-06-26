﻿// <auto-generated />
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
    [Migration("20240225125112_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
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
#pragma warning restore 612, 618
        }
    }
}
