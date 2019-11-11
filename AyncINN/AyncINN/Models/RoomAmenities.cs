using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace AyncINN.Models
{
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
