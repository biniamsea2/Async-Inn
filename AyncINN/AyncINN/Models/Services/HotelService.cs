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
    /// The HotelService is using a dependency injection, we are injecting the IHotelManager interface into this class.
    /// </summary>
    public class HotelService : IHotelManager
    {
        private AsyncInnDbContext _context;

        public HotelService(AsyncInnDbContext context)
        {
            _context = context;
        }

        //This is the create method from our crud operations that we created in our IHotelManager interface. We are able to 
        //create a hotel using this method.
        public async Task CreateHotelAsync(Hotel hotel)
        {
            await _context.Hotel.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        //this method allows us to delete a specific hotel. We pass in the hotel id so that way we know what exact hotel we are deleting.
        public async Task DeleteHotelAsync(int id)
        {
            Hotel hotel = await GetHotelByIDAsync(id);
            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        //Getting a specific hotel by using its ID.
        public async Task<Hotel> GetHotelByIDAsync(int id) => await _context.Hotel.FirstOrDefaultAsync(htl => htl.ID == id);

        //allows you to get all the hotels
        public async Task<List<Hotel>> GetHotelsAsync()
        {
            List<Hotel> hotels = await _context.Hotel.ToListAsync();
            return hotels;
        }

        //allows you to update a hotel
        public async Task UpdateHotelAsync(Hotel hotel)
        {
            _context.Hotel.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
