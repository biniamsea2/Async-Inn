﻿// <auto-generated />
using AyncINN.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AyncINN.Migrations
{
    [DbContext(typeof(AsyncInnDbContext))]
    [Migration("20191105043637_fixingnaming")]
    partial class fixingnaming
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AyncINN.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Big Screen TV"
                        },
                        new
                        {
                            ID = 2,
                            Name = "Mini Bar"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Hot tub"
                        },
                        new
                        {
                            ID = 4,
                            Name = "AC"
                        },
                        new
                        {
                            ID = 5,
                            Name = "Balcony with a view"
                        },
                        new
                        {
                            ID = 6,
                            Name = "Wifi"
                        });
                });

            modelBuilder.Entity("AyncINN.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Seattle",
                            Name = "Rest Easy Inn",
                            Phone = 1234567767,
                            State = "WA",
                            StreetAddress = "1234 15th ave NE"
                        },
                        new
                        {
                            ID = 2,
                            City = "Seattle",
                            Name = "Rest Easy Inn",
                            Phone = 1234567767,
                            State = "WA",
                            StreetAddress = "1234 15th ave NE"
                        },
                        new
                        {
                            ID = 3,
                            City = "New York City",
                            Name = "Sleep Well Inn",
                            Phone = 1644563592,
                            State = "NY",
                            StreetAddress = "5678 19th ave SW"
                        },
                        new
                        {
                            ID = 4,
                            City = "Miami",
                            Name = "Cozy Motel",
                            Phone = 1812673541,
                            State = "FL",
                            StreetAddress = "4282 52nd ave W"
                        },
                        new
                        {
                            ID = 5,
                            City = "Los Angeles",
                            Name = "Stars Inn",
                            Phone = 1457893245,
                            State = "CA",
                            StreetAddress = "32634 Santa Monica Blvd"
                        },
                        new
                        {
                            ID = 6,
                            City = "Oakland",
                            Name = "Cozy Motel",
                            Phone = 1812673541,
                            State = "CA",
                            StreetAddress = "13 Washington St"
                        });
                });

            modelBuilder.Entity("AyncINN.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID")
                        .HasColumnType("int");

                    b.Property<int>("RoomNumber")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<bool>("PetFriendly")
                        .HasColumnType("bit");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.HasKey("HotelID", "RoomNumber");

                    b.HasIndex("RoomID");

                    b.ToTable("HotelRoom");
                });

            modelBuilder.Entity("AyncINN.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Layout")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Layout = 2,
                            Name = "Boom Boom"
                        },
                        new
                        {
                            ID = 2,
                            Layout = 1,
                            Name = "No Boom Boom"
                        },
                        new
                        {
                            ID = 3,
                            Layout = 2,
                            Name = "Honeymoon"
                        },
                        new
                        {
                            ID = 4,
                            Layout = 1,
                            Name = "Lonely"
                        },
                        new
                        {
                            ID = 5,
                            Layout = 2,
                            Name = "R2D2"
                        },
                        new
                        {
                            ID = 6,
                            Layout = 3,
                            Name = "Friends"
                        });
                });

            modelBuilder.Entity("AyncINN.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID")
                        .HasColumnType("int");

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("RoomID");

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AyncINN.Models.HotelRoom", b =>
                {
                    b.HasOne("AyncINN.Models.Hotel", "Hotel")
                        .WithMany("HotelRooms")
                        .HasForeignKey("HotelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AyncINN.Models.Room", "Room")
                        .WithMany("HotelRooms")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AyncINN.Models.RoomAmenities", b =>
                {
                    b.HasOne("AyncINN.Models.Amenities", "Amenities")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AyncINN.Models.Room", "Room")
                        .WithMany("RoomAmenities")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
