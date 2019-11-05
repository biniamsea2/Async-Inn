using AyncINN.Data;
using AyncINN.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Services
{
    public class AmenitiesService : IAmenitiesManager
    {
        private AsyncInnDbContext _context;

        public AmenitiesService(AsyncInnDbContext context)
        {
            _context = context;
        }
        public async Task CreateAmenityAsync(Amenities amenities)
        {
            await _context.Amenities.AddAsync(amenities);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAmenitiesAsync(int id)
        {
            Amenities amenities = await GetAmenityByIDAsync(id);
            _context.Amenities.Remove(amenities);
            await _context.SaveChangesAsync();
        }

        public async Task<Amenities> GetAmenityByIDAsync(int id) => await _context.Amenities.FirstOrDefaultAsync(amn => amn.ID == id);

        public async Task<List<Amenities>> GetAmenitiesAsync()
        {
            List<Amenities> amenities = await _context.Amenities.ToListAsync();
            return amenities;
        }

        public async Task UpdateAmenititesAsync(Amenities amenities)
        {
            _context.Amenities.Update(amenities);
            await _context.SaveChangesAsync();
        }
    }
}
