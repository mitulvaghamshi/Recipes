﻿// <auto-generated />
using DatabaseExplorer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseExplorer.Migrations.BabyNames;

[DbContext(typeof(BabyContext))]
[Migration("20230429004102_Init")]
partial class Init
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

        modelBuilder.Entity("BabyNames.Models.Baby", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Gender")
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnType("TEXT");

                b.Property<string>("Meaning")
                    .HasMaxLength(250)
                    .HasColumnType("TEXT");

                b.Property<int?>("NakshatraId")
                    .HasColumnType("INTEGER");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnType("TEXT");

                b.Property<int?>("Numerology")
                    .HasColumnType("INTEGER");

                b.Property<int?>("ReligionId")
                    .HasColumnType("INTEGER");

                b.Property<int>("Syllables")
                    .HasMaxLength(5)
                    .HasColumnType("INTEGER");

                b.Property<int?>("ZodiacId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex(new[] { "NakshatraId" }, "IX_Baby_NakshatraId");

                b.HasIndex(new[] { "Name" }, "IX_Baby_Name");

                b.HasIndex(new[] { "ReligionId" }, "IX_Baby_ReligionId");

                b.HasIndex(new[] { "ZodiacId" }, "IX_Baby_ZodiacId");

                b.ToTable("Babies");
            });

        modelBuilder.Entity("BabyNames.Models.Nakshatra", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Nakshatras");
            });

        modelBuilder.Entity("BabyNames.Models.Religion", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Religions");
            });

        modelBuilder.Entity("BabyNames.Models.Zodiac", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Latters")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Zodiacs");
            });

        modelBuilder.Entity("BabyNames.Models.Baby", b =>
            {
                b.HasOne("BabyNames.Models.Nakshatra", "Nakshatra")
                    .WithMany("Babies")
                    .HasForeignKey("NakshatraId");

                b.HasOne("BabyNames.Models.Religion", "Religion")
                    .WithMany("Babies")
                    .HasForeignKey("ReligionId");

                b.HasOne("BabyNames.Models.Zodiac", "Zodiac")
                    .WithMany("Babies")
                    .HasForeignKey("ZodiacId");

                b.Navigation("Nakshatra");

                b.Navigation("Religion");

                b.Navigation("Zodiac");
            });

        modelBuilder.Entity("BabyNames.Models.Nakshatra", b =>
            {
                b.Navigation("Babies");
            });

        modelBuilder.Entity("BabyNames.Models.Religion", b =>
            {
                b.Navigation("Babies");
            });

        modelBuilder.Entity("BabyNames.Models.Zodiac", b =>
            {
                b.Navigation("Babies");
            });
#pragma warning restore 612, 618
    }
}
