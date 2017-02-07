using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EcoHostelAPI.Models;
using EcoHostelAPI.ViewModels;

namespace EcoHostelAPI.Services
{
    public class ReservationServices
    {
        public static ApplicationDBContext db = new ApplicationDBContext();
        public static Reservation convertFromVM(ReservationVM vm, System.Security.Claims.ClaimsIdentity user)
        {
            var reservation = new Reservation()
            {
                guestCount = vm.guestCount,
                roomType = vm.typeOfRoom,
                roomID = db.Rooms.First(f => f.roomType == vm.typeOfRoom).ID,
                startDate = vm.fromDate,
                endDate = vm.toDate,
                userID = user.Name
            };
            reservation.room = db.Rooms.First(f => f.ID == reservation.roomID);
            // reservation.user = db.Users.First(f => f.ID == reservation.userID);
            return reservation;
        }
        public static ReservationVM convertToVM(Reservation reservation)
        {
            var vm = new ReservationVM()
            {
                fromDate = reservation.startDate,
                toDate = reservation.endDate,
                typeOfRoom = reservation.roomType,
                guestCount = reservation.guestCount,
                found= true
            };

            return vm;
        }
    }
}