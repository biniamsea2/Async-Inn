using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models
{
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
