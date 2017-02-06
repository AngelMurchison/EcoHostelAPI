using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcoHostelAPI.ViewModels
{
    public class ReservationVM
    {
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public int guestCount { get; set; }
        public string typeOfRoom { get; set; }
    }
}