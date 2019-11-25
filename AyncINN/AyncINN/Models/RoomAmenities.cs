using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AyncINN.Models
{
    /// <summary>
    /// the roomAmenities class will hold information for the each room amenity. Used data notations to set some properties
    /// to required. Also used data notations to change the display name. This class is using composite keys so navigation 
    /// properties were created towards the bottom of the class
    /// </summary>
    public class RoomAmenities
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Amenities ID")]
        public int AmenitiesID { get; set; }
        [Required]
        [Display(Name = "Room ID")]
        public int RoomID { get; set; }

        //nav properties (composite keys)
        public Amenities Amenities { get; set; }
        public Room Room { get; set; }

    }
}
