﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models
{
    /// <summary>
    /// the hotelRoom class has properties that are all required information for each hotel room. Also changed display
    /// names for some properties. This class will include composite keys so, navigation properties are added at the bottom.
    /// </summary>
    public class HotelRoom
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Hotel ID")]
        public int HotelID { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }
        [Required]
        [Display(Name = "Room ID")]
        public int RoomID { get; set; }

        [Required]
        public decimal Rate { get; set; }
        [Required]
        [Display(Name = "Pet Friendly")]
        public bool PetFriendly { get; set; }


        //nav properties (composite keys)
    public Hotel Hotel { get; set; }
    public Room Room { get; set; }
    }




}
