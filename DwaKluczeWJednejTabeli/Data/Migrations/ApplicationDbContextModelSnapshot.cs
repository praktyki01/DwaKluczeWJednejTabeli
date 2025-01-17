﻿// <auto-generated />
using System;
using DwaKluczeWJednejTabeli.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DwaKluczeWJednejTabeli.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Druzyna", b =>
                {
                    b.Property<int>("DruzynaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DruzynaId"));

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Miasto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RokZalozenia")
                        .HasColumnType("int");

                    b.Property<string>("Trener")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DruzynaId");

                    b.ToTable("Druzyna");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Mecz", b =>
                {
                    b.Property<int>("MeczId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MeczId"));

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("GoscieDruzynaId")
                        .HasColumnType("int");

                    b.Property<int>("GospodarzeDruzynaId")
                        .HasColumnType("int");

                    b.Property<string>("Wynik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MeczId");

                    b.HasIndex("GoscieDruzynaId");

                    b.HasIndex("GospodarzeDruzynaId");

                    b.ToTable("Mecz");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Sedzia", b =>
                {
                    b.Property<int>("SedziaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SedziaId"));

                    b.Property<int?>("DruzynaId")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WystawioneZolteKartki")
                        .HasColumnType("int");

                    b.HasKey("SedziaId");

                    b.HasIndex("DruzynaId");

                    b.ToTable("Sedzia");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Sponsor", b =>
                {
                    b.Property<int>("SponsorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SponsorId"));

                    b.Property<int>("DruzynaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Kwota")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SponsorId");

                    b.HasIndex("DruzynaId");

                    b.ToTable("Sponsor");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Statystyki", b =>
                {
                    b.Property<int>("StatystykiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StatystykiId"));

                    b.Property<int>("Asysty")
                        .HasColumnType("int");

                    b.Property<int>("CzerwoneKartki")
                        .HasColumnType("int");

                    b.Property<int>("Gole")
                        .HasColumnType("int");

                    b.Property<int>("MeczId")
                        .HasColumnType("int");

                    b.Property<int>("ZawodnikId")
                        .HasColumnType("int");

                    b.Property<int>("ZolteKartki")
                        .HasColumnType("int");

                    b.HasKey("StatystykiId");

                    b.HasIndex("MeczId");

                    b.HasIndex("ZawodnikId");

                    b.ToTable("Statystyki");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Tabela", b =>
                {
                    b.Property<int>("TabelaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TabelaId"));

                    b.Property<int>("DruzynaId")
                        .HasColumnType("int");

                    b.Property<int>("Porazki")
                        .HasColumnType("int");

                    b.Property<int>("Punkty")
                        .HasColumnType("int");

                    b.Property<int>("Remisy")
                        .HasColumnType("int");

                    b.Property<int>("RozegraneMecze")
                        .HasColumnType("int");

                    b.Property<int>("StraconeBramki")
                        .HasColumnType("int");

                    b.Property<int>("StrzeloneBramki")
                        .HasColumnType("int");

                    b.Property<int>("Zwyciestwa")
                        .HasColumnType("int");

                    b.HasKey("TabelaId");

                    b.HasIndex("DruzynaId");

                    b.ToTable("Tabela");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Zawodnik", b =>
                {
                    b.Property<int>("ZawodnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZawodnikId"));

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<int>("DruzynaId")
                        .HasColumnType("int");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kraj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pozycja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZawodnikId");

                    b.HasIndex("DruzynaId");

                    b.ToTable("Zawodnik");
                });

            modelBuilder.Entity("MeczSedzia", b =>
                {
                    b.Property<int>("MeczId")
                        .HasColumnType("int");

                    b.Property<int>("SedziasSedziaId")
                        .HasColumnType("int");

                    b.HasKey("MeczId", "SedziasSedziaId");

                    b.HasIndex("SedziasSedziaId");

                    b.ToTable("MeczSedzia");
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Mecz", b =>
                {
                    b.HasOne("DwaKluczeWJednejTabeli.Models.Druzyna", "GoscieDruzyna")
                        .WithMany("MeczGoscies")
                        .HasForeignKey("GoscieDruzynaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("DwaKluczeWJednejTabeli.Models.Druzyna", "GospodarzeDruzyna")
                        .WithMany("MeczGospodarzes")
                        .HasForeignKey("GospodarzeDruzynaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GoscieDruzyna");

                    b.Navigation("GospodarzeDruzyna");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Sedzia", b =>
                {
                    b.HasOne("DwaKluczeWJednejTabeli.Models.Druzyna", null)
                        .WithMany("Sedzias")
                        .HasForeignKey("DruzynaId");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Sponsor", b =>
                {
                    b.HasOne("DwaKluczeWJednejTabeli.Models.Druzyna", "Druzyna")
                        .WithMany("Sponsors")
                        .HasForeignKey("DruzynaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Druzyna");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Statystyki", b =>
                {
                    b.HasOne("DwaKluczeWJednejTabeli.Models.Mecz", "Mecz")
                        .WithMany("Statystykis")
                        .HasForeignKey("MeczId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DwaKluczeWJednejTabeli.Models.Zawodnik", "Zawodnik")
                        .WithMany("Statystykis")
                        .HasForeignKey("ZawodnikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mecz");

                    b.Navigation("Zawodnik");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Tabela", b =>
                {
                    b.HasOne("DwaKluczeWJednejTabeli.Models.Druzyna", "Druzyna")
                        .WithMany()
                        .HasForeignKey("DruzynaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Druzyna");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Zawodnik", b =>
                {
                    b.HasOne("DwaKluczeWJednejTabeli.Models.Druzyna", "Druzyna")
                        .WithMany("Zawodniks")
                        .HasForeignKey("DruzynaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Druzyna");
                });

            modelBuilder.Entity("MeczSedzia", b =>
                {
                    b.HasOne("DwaKluczeWJednejTabeli.Models.Mecz", null)
                        .WithMany()
                        .HasForeignKey("MeczId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DwaKluczeWJednejTabeli.Models.Sedzia", null)
                        .WithMany()
                        .HasForeignKey("SedziasSedziaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Druzyna", b =>
                {
                    b.Navigation("MeczGoscies");

                    b.Navigation("MeczGospodarzes");

                    b.Navigation("Sedzias");

                    b.Navigation("Sponsors");

                    b.Navigation("Zawodniks");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Mecz", b =>
                {
                    b.Navigation("Statystykis");
                });

            modelBuilder.Entity("DwaKluczeWJednejTabeli.Models.Zawodnik", b =>
                {
                    b.Navigation("Statystykis");
                });
#pragma warning restore 612, 618
        }
    }
}
