using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KnockmittenBooking.Models
{
    public class Booking
    {
        [Required]
        [ForeignKey("Client")]
        public int ID { get; set; }
        [Required]
        [ForeignKey("Room")]
        public int RoomID { get; set; }

        public bool Booked { get; set; }

        public virtual Client Clients { get; set;}
        public virtual Room Rooms { get; set; }
    }
}