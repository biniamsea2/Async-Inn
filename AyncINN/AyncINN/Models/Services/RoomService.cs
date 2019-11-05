using AyncINN.Data;
using AyncINN.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Services
{
    public class RoomService : IRoomManager
    {
        private AsyncInnDbContext _context;

        public RoomService(AsyncInnDbContext context)
        {
            _context = context;

        }
        public async Task CreateRoom(Room room)
        {
            await _context.Room.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoom(int id)
        {
            Room room = await GetRoomByID(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
        }

        public async Task<Room> GetRoomByID(int id) => await _context.Room.FirstOrDefaultAsync(rm => rm.ID == id);


        public async Task<List<Room>> GetRooms()
        {
            List<Room> rooms = await _context.Room.ToListAsync();
            return rooms;
        }

        public async Task UpdateRoom(Room room)
        {
            _context.Room.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
