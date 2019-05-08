using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingCA2.Models
{
    public class Booking
    {
        [Required]
        public int BookingID { get; set; }

        [Required]
        [ForeignKey("Clients")]
        public int ClientID { get; set; }
        [Required]
        [ForeignKey("Rooms")]
        public int RoomID { get; set; }

        public bool Booked { get; set; }

        public virtual Client Clients { get; set; }
        public virtual Room Rooms { get; set; }
    }
}