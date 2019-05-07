using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnockmittenBooking.Models
{
    public class Room
    {

        [Required]
        public int RoomID { get; set; }

        [Required]
        [Display(Name = "Room Number")]

        public string RoomNumber { get; set; }

        [Required]
        [Display(Name = "Date of booking")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Will you require teas and coffees?")]
        public bool Teas { get; set; }
    }
}
