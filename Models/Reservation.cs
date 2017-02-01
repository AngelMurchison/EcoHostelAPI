using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using EcoHostelAPI.Models;

namespace EcoHostelAPI.Models
{
    public class Reservation
    { 
        [Key]
        public int ID { get; set; }
        [Required]
        public int roomID { get; set; }
        [Required]
        public string userID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        [ForeignKey("roomID")]
        public virtual Room room { get; set; }
        [ForeignKey("userID")]
        public virtual User user { get; set; }

    }
}