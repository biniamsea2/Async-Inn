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
    /// using dependecny injection in this service. We are injecting the IAmenitiesManager. The AmenitiesService class
    /// will create all of our crud operations that we listed in our IAmenitiesManager interface. 
    /// </summary>
    public class AmenitiesService : IAmenitiesManager
    {
        private AsyncInnDbContext _context;

        public AmenitiesService(AsyncInnDbContext context)
        {
            _context = context;
        }
        //method allows us to create an amenity
        public async Task CreateAmenityAsync(Amenities amenities)
        {
            await _context.Amenities.AddAsync(amenities);
            await _context.SaveChangesAsync();
        }

        //this method allows us to delete a specific amenity that we pass in as a parameter.
        public async Task DeleteAmenitiesAsync(int id)
        {
            Amenities amenities = await GetAmenityByIDAsync(id);
            _context.Amenities.Remove(amenities);
            await _context.SaveChangesAsync();
        }

        //In this method we are getting a specific amenity. Doing this in a one liner.
        public async Task<Amenities> GetAmenityByIDAsync(int id) => await _context.Amenities.FirstOrDefaultAsync(amn => amn.ID == id);

        //this method allows us to get all the amenities.
        public async Task<List<Amenities>> GetAmenitiesAsync()
        {
            List<Amenities> amenities = await _context.Amenities.ToListAsync();
            return amenities;
        }

        //this method allows us to update a specific amenity, we are passing that amenity in as a parameter.
        public async Task UpdateAmenititesAsync(Amenities amenities)
        {
            _context.Amenities.Update(amenities);
            await _context.SaveChangesAsync();
        }
    }
}
