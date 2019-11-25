using AyncINN.Data;
using AyncINN.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Services
{
    /// <summary>
    /// the RoomService class is also using dependency injection; we are injecting the IRoomManager into this class
    /// </summary>
    public class RoomService : IRoomManager
    {
        private AsyncInnDbContext _context;

        public RoomService(AsyncInnDbContext context)
        {
            _context = context;

        }
        //create a room
        public async Task CreateRoomAsync(Room room)
        {
            await _context.Room.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        //delete a specific room by using its id
        public async Task DeleteRoomAsync(int id)
        {
            Room room = await GetRoomByIDAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
        }
        //get all the roomamenities for this specific room by passing in the room's id as a parameter.
        public IEnumerable<RoomAmenities> GetRoomAmenitiesByRoomID(int RoomID)
        {
            var roomAmenity = _context.RoomAmenities.Where(x => x.RoomID == RoomID)
            .Include(x => x.Room)
            .Include(x => x.Amenities);

            return roomAmenity;
        
        }

        //getting a sepcific roomamenity by using its id
        public async Task<Room> GetRoomByIDAsync(int id) => await _context.Room.FirstOrDefaultAsync(rm => rm.ID == id);

        //Get all the rooms 
        public async Task<List<Room>> GetRoomsAsync()
        {
            List<Room> rooms = await _context.Room.ToListAsync();
            return rooms;
        }
        //update a specific room
        public async Task UpdateRoomAsync(Room room)
        {
            _context.Room.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
