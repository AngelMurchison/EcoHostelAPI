using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoHostelAPI.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public DateTime datetime { get; set; }
    }
}