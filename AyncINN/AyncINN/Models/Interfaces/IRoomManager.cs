using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    public interface IRoomManager
    {
        //Create hotel
            Task CreateRoom(Room room);

            //Get individual Hotel
            Task<Room> GetRoomByID(int id);

            //Get all hotels
            Task<List<Room>> GetRooms();

            //Update hotel
            Task UpdateRoom(Room room);

            //Delete hotel
            Task DeleteRoom(int id);

    }
}
