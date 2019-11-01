using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models
{
    public class RoomAmenities
    {
        public int ID { get; set; }
        public int AmenitiesID { get; set; }
        public int RoomID { get; set; }

        //nav properties (composite keys)
        public ICollection<Amenities> Amenities { get; set; }
        public ICollection<Room> Room { get; set; }

    }
}
