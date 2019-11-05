using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    public interface IHotelManager
    {
        //Create hotel
        Task CreateHotel(Hotel hotel);

        //Get individual Hotel
        Task<Hotel> GetHotelByID(int id);

        //Get all hotels
        Task<List<Hotel>> GetHotels();

        //Update hotel
        Task UpdateHotel(Hotel hotel);

        //Delete hotel
        Task DeleteHotel(int id);

    }
}
