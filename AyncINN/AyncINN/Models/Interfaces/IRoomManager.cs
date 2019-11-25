using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    /// <summary>
    /// the iRoomManager is an interface that holds all of our crud operations. We will inject this interface into 
    /// our RoomService.
    /// </summary>
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
        
        //Get amenities
        IEnumerable<RoomAmenities> GetRoomAmenitiesByRoomID(int RoomID);

    }
}
