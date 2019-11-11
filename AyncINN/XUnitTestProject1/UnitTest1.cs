using System;
using Xunit;
using AyncINN;
using AyncINN.Models;
using Microsoft.EntityFrameworkCore;
using AyncINN.Data;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CreateHotel()
        {
            Hotel test = new Hotel();
            test.ID = 2;
            test.Name = "Test Hotel";
            test.Phone = "2068797494";
            test.State = "WA";
            test.StreetAddress = "1234 4th ave sw";
            test.City = "Seattle";

            Assert.Equal(2, test.ID);
            Assert.Equal("Test Hotel", test.Name);
            Assert.Equal("2068797494", test.Phone);
            Assert.Equal("WA", test.State);
            Assert.Equal("1234 4th ave sw", test.StreetAddress);
            Assert.Equal("Seattle", test.City);
        }

        [Fact]
        public void CanEditHotel()
        {
            Hotel test = new Hotel();
            test.ID = 2;
            test.Name = "Test Hotel";
            test.Name = "Name change Hotel";

            Assert.Equal(2, test.ID);
            Assert.Equal("Name change Hotel", test.Name);

        }

        [Fact]
        public void CreateAnAmenity()
        {
            Amenities testA = new Amenities();
            testA.ID = 1;
            testA.Name = "Extra pillows";



            Assert.Equal(1, testA.ID);
            Assert.Equal("Extra pillows", testA.Name);

        }

        [Fact]
        public void CanEditAmenity()
        {
            Amenities testB = new Amenities();
            testB.ID = 2;
            testB.Name = "Extra covers";
            testB.Name = "No extra covers";

            Assert.Equal(2, testB.ID);
            Assert.Equal("No extra covers", testB.Name);

        }

        [Fact]
        public void CreateARoom()
        {
            Room roomc = new Room();
            roomc.ID = 1;
            roomc.Name = "Room";
            roomc.Layout = Layout.OneBedroom;



            Assert.Equal(1, roomc.ID);
            Assert.Equal("Room", roomc.Name);
            Assert.Equal(Layout.OneBedroom, roomc.Layout);

        }

        [Fact]
        public void CanEditARoom()
        {
            Room roomc = new Room();
            roomc.ID = 1;
            roomc.Name = "Room";
            roomc.Name = "Room Change";

            Assert.Equal(1, roomc.ID);
            Assert.Equal("Room Change", roomc.Name);

        }

        [Fact]
        public void CreateAHotelRoom()
        {
            HotelRoom hotelroom = new HotelRoom();
            hotelroom.HotelID = 1;
            hotelroom.RoomID = 2;
            hotelroom.PetFriendly = false;
            hotelroom.Rate = 100;
            hotelroom.RoomNumber = 20;

            Assert.Equal(1, hotelroom.HotelID);
            Assert.Equal(2, hotelroom.RoomID);
            Assert.False(hotelroom.PetFriendly);
            Assert.Equal(100, hotelroom.Rate);
            Assert.Equal(20, hotelroom.RoomNumber);

        }

        [Fact]
        public void CanEditAHotelRoom()
        {
            HotelRoom hotelroom = new HotelRoom();
            hotelroom.HotelID = 1;
            hotelroom.RoomID = 2;
            hotelroom.PetFriendly = false;
            hotelroom.PetFriendly = true;


            Assert.Equal(1, hotelroom.HotelID);
            Assert.Equal(2, hotelroom.RoomID);
            Assert.True(hotelroom.PetFriendly);
        }

        [Fact]
        public void CreateARoomAmenity()
        {
            RoomAmenities roomAmenities = new RoomAmenities();
            roomAmenities.ID = 1;
            roomAmenities.AmenitiesID = 1;
            roomAmenities.RoomID = 1;

            Assert.Equal(1, roomAmenities.ID);
            Assert.Equal(1, roomAmenities.AmenitiesID);
            Assert.Equal(1, roomAmenities.RoomID);

        }

        [Fact]
        public void CanEditARoomAmenity()
        {
            RoomAmenities roomAmenities = new RoomAmenities();
            roomAmenities.ID = 1;
            roomAmenities.ID = 2;
            roomAmenities.AmenitiesID = 1;
            roomAmenities.AmenitiesID = 2;
            roomAmenities.RoomID = 1;
            roomAmenities.RoomID = 2;

            Assert.Equal(2, roomAmenities.ID);
            Assert.Equal(2, roomAmenities.AmenitiesID);
            Assert.Equal(2, roomAmenities.RoomID);
        }

        [Fact]
        public async void CanSaveHotelInDB()
        {
            DbContextOptions<AsyncInnDbContext> options = new
                DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("SavingHotelinDB")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Hotel savehotel = new Hotel();
                savehotel.Name = "Test save Hotel";
                savehotel.Phone = "2344549444";
                savehotel.State = "CA";
                savehotel.StreetAddress = "1234 4th ave sw";
                savehotel.City = "LA";

                context.Hotel.Add(savehotel);
                await context.SaveChangesAsync();

                Hotel result = await context.Hotel.FirstOrDefaultAsync(x => x.Name == savehotel.Name);
                Assert.Equal("LA", result.City);

            }
        }

        [Fact]
        public async void CanSaveRoomInDB()
        {
            DbContextOptions<AsyncInnDbContext> options = new
                DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("SavingRoominDB")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Room saveroom = new Room();
                saveroom.Name = "Save room";
                saveroom.Layout = Layout.OneBedroom;

                context.Room.Add(saveroom);
                await context.SaveChangesAsync();

                Room result = await context.Room.FirstOrDefaultAsync(x => x.Name == saveroom.Name);
                Assert.Equal("Save room", result.Name);

            }
        }

        [Fact]
        public async void CanSaveAmenityInDB()
        {
            DbContextOptions<AsyncInnDbContext> options = new
                DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("SavingAmenityInDB")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                Amenities saveamenity = new Amenities();
                saveamenity.Name = "Smoking Allowed";

                context.Amenities.Add(saveamenity);
                await context.SaveChangesAsync();

                Amenities result = await context.Amenities.FirstOrDefaultAsync(x => x.Name == saveamenity.Name);
                Assert.Equal("Smoking Allowed", result.Name);

            }
        }

        [Fact]
        public async void CanSaveHotelRoomInDB()
        {
            DbContextOptions<AsyncInnDbContext> options = new
                DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("SavingHotelRoom")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                HotelRoom savehotelroom = new HotelRoom();
                savehotelroom.HotelID = 1;
                savehotelroom.RoomID = 1;
                savehotelroom.PetFriendly = false;
                savehotelroom.Rate = 10;
                savehotelroom.RoomNumber = 100;


                context.HotelRoom.Add(savehotelroom);
                await context.SaveChangesAsync();

                HotelRoom result = await context.HotelRoom.FirstOrDefaultAsync(x => x.PetFriendly == savehotelroom.PetFriendly);
                Assert.False(result.PetFriendly);

            }
        }

        [Fact]
        public async void CanSaveRoomAmenityInDB()
        {
            DbContextOptions<AsyncInnDbContext> options = new
                DbContextOptionsBuilder<AsyncInnDbContext>()
                .UseInMemoryDatabase("SavingRoomAmenityInDB")
                .Options;

            using (AsyncInnDbContext context = new AsyncInnDbContext(options))
            {
                RoomAmenities saveRoomAmenity = new RoomAmenities();
                saveRoomAmenity.AmenitiesID = 2;
                saveRoomAmenity.RoomID = 2;

                context.RoomAmenities.Add(saveRoomAmenity);
                await context.SaveChangesAsync();

                RoomAmenities result = await context.RoomAmenities.FirstOrDefaultAsync(x => x.AmenitiesID == saveRoomAmenity.AmenitiesID);
                Assert.Equal(2,result.AmenitiesID);

            }
        }
    }
}
