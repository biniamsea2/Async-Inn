using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    public interface IHotelManager
    {
        //Create hotel
        Task CreateHotelAsync(Hotel hotel);

        //Get individual Hotel
        Task<Hotel> GetHotelByIDAsync(int id);

        //Get all hotels
        Task<List<Hotel>> GetHotelsAsync();

        //Update hotel
        Task UpdateHotelAsync(Hotel hotel);

        //Delete hotel
        Task DeleteHotelAsync(int id);

    }
}
