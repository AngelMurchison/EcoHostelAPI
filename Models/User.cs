using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoHostelAPI.Models
{
    public class User
    {
        public string ID { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string userName { get; set; }
    }
}