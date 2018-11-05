﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RestaurantReservation.Data.EF;
using System;

namespace RestaurantReservation.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.AutorizacijskiToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DeviceInfo");

                    b.Property<string>("IpAdresa");

                    b.Property<int>("KorisnickiNalogId");

                    b.Property<string>("Vrijednost");

                    b.Property<DateTime>("VrijemeEvidentiranja");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutorizacijskiToken");
                });

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.KorisnickiNalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("KorisnickoIme");

                    b.Property<string>("Lozinka");

                    b.HasKey("Id");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Ime");

                    b.Property<int?>("KorisnickiNalogId");

                    b.Property<string>("Mail");

                    b.Property<string>("Prezime");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.Restoran", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresa");

                    b.Property<string>("Grad");

                    b.Property<string>("Mail");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.Property<string>("Telefon");

                    b.HasKey("Id");

                    b.ToTable("Restoran");
                });

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.Rezervacija", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum");

                    b.Property<int?>("KorisnikId");

                    b.Property<int?>("RestoranId");

                    b.Property<DateTime>("Vrijeme");

                    b.Property<string>("Vrsta");

                    b.HasKey("Id");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("RestoranId");

                    b.ToTable("Rezervacija");
                });

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.AutorizacijskiToken", b =>
                {
                    b.HasOne("RestaurantReservation.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.Korisnik", b =>
                {
                    b.HasOne("RestaurantReservation.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId");
                });

            modelBuilder.Entity("RestaurantReservation.Data.EntityModels.Rezervacija", b =>
                {
                    b.HasOne("RestaurantReservation.Data.EntityModels.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.HasOne("RestaurantReservation.Data.EntityModels.Restoran", "Restoran")
                        .WithMany()
                        .HasForeignKey("RestoranId");
                });
#pragma warning restore 612, 618
        }
    }
}
