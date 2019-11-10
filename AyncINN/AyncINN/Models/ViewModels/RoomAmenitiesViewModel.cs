using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models.ViewModels
{
    public class RoomAmenitiesViewModel
    {
        public IEnumerable<RoomAmenities> RoomAmenities { get; set; }
        public Room Room { get; set; }
    }
}
