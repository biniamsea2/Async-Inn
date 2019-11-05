using AyncINN.Data;
using AyncINN.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Services
{
    public class HotelService : IHotelManager
    {
        private AsyncInnDbContext _context;

        public HotelService(AsyncInnDbContext context)
        {
            _context = context;
        }
        public async Task CreateHotelAsync(Hotel hotel)
        {
            await _context.Hotel.AddAsync(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHotelAsync(int id)
        {
            Hotel hotel = await GetHotelByIDAsync(id);
            _context.Hotel.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<Hotel> GetHotelByIDAsync(int id) => await _context.Hotel.FirstOrDefaultAsync(htl => htl.ID == id);

        public async Task<List<Hotel>> GetHotelsAsync()
        {
            List<Hotel> hotels = await _context.Hotel.ToListAsync();
            return hotels;
        }

        public async Task UpdateHotelAsync(Hotel hotel)
        {
            _context.Hotel.Update(hotel);
            await _context.SaveChangesAsync();
        }
    }
}
