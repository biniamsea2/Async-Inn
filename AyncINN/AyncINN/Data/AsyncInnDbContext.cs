using AyncINN.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Data
{
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
                    Phone = 1234567767
                },


                new Hotel
                {
                    ID = 2,
                    Name = "Rest Easy Inn",
                    StreetAddress = "1234 15th ave NE",
                    City = "Seattle",
                    State = "WA",
                    Phone = 1234567767
                },


                new Hotel
                {
                    ID = 3,
                    Name = "Sleep Well Inn",
                    StreetAddress = "5678 19th ave SW",
                    City = "New York City",
                    State = "NY",
                    Phone = 1644563592
                },

                  new Hotel
                  {
                      ID = 4,
                      Name = "Cozy Motel",
                      StreetAddress = "4282 52nd ave W",
                      City = "Miami",
                      State = "FL",
                      Phone = 1812673541
                  },

                  new Hotel
                  {
                      ID = 5,
                      Name = "Stars Inn",
                      StreetAddress = "32634 Santa Monica Blvd",
                      City = "Los Angeles",
                      State = "CA",
                      Phone = 1457893245
                  },

                  new Hotel
                  {
                      ID = 6,
                      Name = "Cozy Motel",
                      StreetAddress = "13 Washington St",
                      City = "Oakland",
                      State = "CA",
                      Phone = 1812673541
                  }


                );

            modelBuilder.Entity<Room>().HasData(
             new Room
             {
                 ID = 1,
                 Name = "Boom Boom",
                 Layout = Layout.OneBedroom
             },

               new Room
               {
                   ID = 2,
                   Name = "No Boom Boom",
                   Layout = Layout.Studio
               },

                 new Room
                 {
                     ID = 3,
                     Name = "Boom Boom",
                     Layout = Layout.TwoBedroom
                 },

                   new Room
                   {
                       ID = 4,
                       Name = "Lonely",
                       Layout = Layout.Studio
                   },

                     new Room
                     {
                         ID = 5,
                         Name = "R2D2",
                         Layout = Layout.OneBedroom
                     },

                       new Room
                       {
                           ID = 6,
                           Name = "Friends",
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
