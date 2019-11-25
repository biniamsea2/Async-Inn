using AyncINN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Data
{
    /// <summary>
    /// seeding in information reagarding hotels, rooms, and amenitites
    /// </summary>
    public class AsyncInnDbContext : DbContext
    {
        public AsyncInnDbContext(DbContextOptions<AsyncInnDbContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HotelRoom>().HasKey(HotelRoom =>
            new { HotelRoom.HotelID, HotelRoom.RoomNumber });

            modelBuilder.Entity<RoomAmenities>().HasKey(RoomAmenities =>
            new { RoomAmenities.AmenitiesID, RoomAmenities.RoomID });

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    ID = 1,
                    Name = "Rest Easy Inn",
                    StreetAddress = "1234 15th ave NE",
                    City = "Seattle",
                    State = "WA",
                    Phone = "(206)985-8493"
                },


                new Hotel
                {
                    ID = 2,
                    Name = "Comfy Hotel",
                    StreetAddress = "1234 15th ave NE",
                    City = "Seattle",
                    State = "WA",
                    Phone = "(206)584-3674"
                },


                new Hotel
                {
                    ID = 3,
                    Name = "Sleep Well Inn",
                    StreetAddress = "5678 19th ave SW",
                    City = "New York City",
                    State = "NY",
                    Phone = "(212)673-6483"
                },

                  new Hotel
                  {
                      ID = 4,
                      Name = "Restful Motel",
                      StreetAddress = "4282 52nd ave W",
                      City = "Miami",
                      State = "FL",
                      Phone = "(786)385-7912"
                  },

                  new Hotel
                  {
                      ID = 5,
                      Name = "Stars Inn",
                      StreetAddress = "32634 Santa Monica Blvd",
                      City = "Los Angeles",
                      State = "CA",
                      Phone = "(213)789-3841"
                  },

                  new Hotel
                  {
                      ID = 6,
                      Name = "Cozy Motel",
                      StreetAddress = "13 Washington St",
                      City = "Oakland",
                      State = "CA",
                      Phone = "(510)796-3984"
                  }


                );

            modelBuilder.Entity<Room>().HasData(
             new Room
             {
                 ID = 1,
                 Name = "House Stark",
                 Layout = Layout.OneBedroom
             },

               new Room
               {
                   ID = 2,
                   Name = "House Frey",
                   Layout = Layout.Studio,
               },

                 new Room
                 {
                     ID = 3,
                     Name = "House Lannister",
                     Layout = Layout.OneBedroom
                 },

                   new Room
                   {
                       ID = 4,
                       Name = "House Tyrell",
                       Layout = Layout.Studio
                   },

                     new Room
                     {
                         ID = 5,
                         Name = "House Targaryen",
                         Layout = Layout.OneBedroom
                     },

                       new Room
                       {
                           ID = 6,
                           Name = "House Baratheon",
                           Layout = Layout.TwoBedroom
                       }
                       );

            modelBuilder.Entity<Amenities>().HasData(
            new Amenities
            {
                ID = 1,
                Name = "Big Screen TV"
            },
            new Amenities
            {
                ID = 2,
                Name = "Mini Bar"
            },
            new Amenities
            {
                ID = 3,
                Name = "Hot tub"
            },
            new Amenities
            {
                ID = 4,
                Name = "AC"
            },
            new Amenities
            {
                ID = 5,
                Name = "Balcony with a view"
            },
            new Amenities
            {
                ID = 6,
                Name = "Wifi"
            }
           );
        }



        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
    }
}
