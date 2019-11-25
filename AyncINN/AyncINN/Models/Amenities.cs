using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AyncINN.Models
{
    /// <summary>
    /// created amenities class that will have 2 properties, its id and name. Using data notations to make the name
    /// property a required field.
    /// </summary>
    public class Amenities
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }



        public ICollection<RoomAmenities> RoomAmenities { get; set; }


    }
}
