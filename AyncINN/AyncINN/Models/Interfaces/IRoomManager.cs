using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    public interface IRoomManager
    {
            //Create room
            Task CreateRoom(Room room);

            //Get individual room
            Task<Room> GetRoomByID(int id);

            //Get all rooms
            Task<List<Room>> GetRooms();

            //Update room
            Task UpdateRoom(Room room);

            //Delete room
            Task DeleteRoom(int id);

    }
}
