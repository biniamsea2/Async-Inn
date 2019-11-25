using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models
{

    /// <summary>
    /// hotel class will hold properties that will be used as infomation for each hotel.
    /// Also added data notations making all properties required and changing display name for address
    /// </summary>
    public class Hotel
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }



    //navigation properties 
    public ICollection<HotelRoom> HotelRooms { get; set; }
    }


}
