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

        }



        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Amenities> Amenities { get; set; }
        public DbSet<HotelRoom> HotelRoom { get; set; }
        public DbSet<Room> Room { get; set; }
        public DbSet<RoomAmenities> RoomAmenities { get; set; }
    }
}
