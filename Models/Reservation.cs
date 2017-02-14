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
        public string userID { get; set; }
        public int roomID { get; set; }
        public string roomType { get; set; }
        public int guestCount { get; set; }
        public DateTime? startDate { get; set; }
        public DateTime? endDate { get; set; }
    }
}