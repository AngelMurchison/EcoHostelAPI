using System;
using System.Collections.Generic;
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
        public int ID { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public int capacity { get; set; }
        public int vacancy { get; set; }
    }
}