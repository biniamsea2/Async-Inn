using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models
{
    public class HotelRoom
    {
        public int ID { get; set; }
        public int HotelID { get; set; }

        [Required]
        public int RoomNumber { get; set; }
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
