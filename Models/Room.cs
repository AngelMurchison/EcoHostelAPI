using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcoHostelAPI.Models
{
    public class Room
    {
        [Key]
        public int ID { get; set; }
        public string roomType { get; set; }
    }
}