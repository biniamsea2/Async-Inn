using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models
{
    /// <summary>
    /// The room class will hold the layout in addition to the other properties. The layout is listed as an enum at the 
    /// bottom of this class. Data notations are added to make certain information required. Also, changed the display name for the 
    /// room name property. This class includes the use of composite keys, so the navigation property is included in this class.
    /// </summary>
    public class Room
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Room Name")]
        public string Name { get; set; }
        public Layout Layout { get; set; }


        //nav properties (composite keys)
        public ICollection<RoomAmenities> RoomAmenities { get; set; }
        public ICollection<HotelRoom> HotelRooms { get; set; }


    }
    public enum Layout
    {
        Studio = 1,
        [Display(Name = "One Bedroom")]
        OneBedroom,
        [Display(Name = "Two Bedroom")]
        TwoBedroom
    }

}
