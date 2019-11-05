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
        public async Task CreateRoomAsync(Room room)
        {
            await _context.Room.AddAsync(room);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRoomAsync(int id)
        {
            Room room = await GetRoomByIDAsync(id);
            _context.Room.Remove(room);
            await _context.SaveChangesAsync();
        }

        public async Task<Room> GetRoomByIDAsync(int id) => await _context.Room.FirstOrDefaultAsync(rm => rm.ID == id);


        public async Task<List<Room>> GetRoomsAsync()
        {
            List<Room> rooms = await _context.Room.ToListAsync();
            return rooms;
        }

        public async Task UpdateRoomAsync(Room room)
        {
            _context.Room.Update(room);
            await _context.SaveChangesAsync();
        }
    }
}
