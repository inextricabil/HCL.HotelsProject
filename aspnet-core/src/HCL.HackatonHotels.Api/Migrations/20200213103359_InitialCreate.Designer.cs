﻿// <auto-generated />
using System;
using HCl.Hotel.Api.DataProvider.ProductService.DataProvider;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HCL.HackatonHotels.Api.Migrations
{
    [DbContext(typeof(HotelDbContext))]
    [Migration("20200213103359_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.BookedRoom", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ClientId");

                    b.Property<DateTime>("EndDate");

                    b.Property<long>("RoomId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("RoomId");

                    b.ToTable("BookedRooms");
                });

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.Client", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.Hotel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<long>("LocationId");

                    b.Property<string>("Name")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.Property<string>("StreetDetails");

                    b.HasKey("Id");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.Room", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<long>("HotelId");

                    b.Property<decimal>("Price");

                    b.Property<int>("RoomNumber")
                        .HasMaxLength(200);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.BookedRoom", b =>
                {
                    b.HasOne("HCl.Hotel.Api.DataProvider.Models.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("HCl.Hotel.Api.DataProvider.Models.Room", "Room")
                        .WithMany("Books")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.Hotel", b =>
                {
                    b.HasOne("HCl.Hotel.Api.DataProvider.Models.Location", "Location")
                        .WithMany("Hotels")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HCl.Hotel.Api.DataProvider.Models.Room", b =>
                {
                    b.HasOne("HCl.Hotel.Api.DataProvider.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
