using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EcoHostelAPI.Models
{
    public class Room
    {
        public Room()
        {
            this.capacity = 20;
            this.vacancy = this.capacity;
        }

        [Key]
        public int ID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public int capacity { get; set; }
        public int vacancy { get; set; }
    }
}