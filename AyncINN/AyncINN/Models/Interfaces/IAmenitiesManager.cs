using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        //Create amenity 
        Task CreateAmenity(Amenities amenities);

        //Get individual amenity
        Task<Amenities> GetAmenityByID(int id);

        //Get all amenities
        Task<List<Amenities>> GetAmenities();

        //Update amenity
        Task UpdateAmenitites(Amenities amenities);

        //Delete amenity
        Task DeleteAmenities(int id);
    }
}
