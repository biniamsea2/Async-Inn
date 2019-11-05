using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    public interface IRoomManager
    {
            //Create room
            Task CreateRoomAsync(Room room);

            //Get individual room
            Task<Room> GetRoomByIDAsync(int id);

            //Get all rooms
            Task<List<Room>> GetRoomsAsync();

            //Update room
            Task UpdateRoomAsync(Room room);

            //Delete room
            Task DeleteRoomAsync(int id);

    }
}
