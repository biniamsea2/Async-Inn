using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        //Create amenity 
        Task CreateAmenityAsync(Amenities amenities);

        //Get individual amenity
        Task<Amenities> GetAmenityByIDAsync(int id);

        //Get all amenities
        Task<List<Amenities>> GetAmenitiesAsync();

        //Update amenity
        Task UpdateAmenititesAsync(Amenities amenities);

        //Delete amenity
        Task DeleteAmenitiesAsync(int id);
    }
}
