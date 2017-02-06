using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EcoHostelAPI.Models;
using EcoHostelAPI.ViewModels;
using EcoHostelAPI.Services;
using System.Data.Entity.Migrations;

namespace EcoHostelAPI.Controllers
{
    public class ReservationController : ApiController
    {
        public static ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/Reservation
        [Authorize]
        public IHttpActionResult GetUsersReservation()
        {
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userid = user.Claims.First(f => f.Type == "user_id").Value;
            var reservation = db.Reservations.LastOrDefault(f => f.userID == userid);
            var vm = Services.ReservationServices.convertToVM(reservation);

            return Ok(vm);
        }

        // POST: api/Reservation
        [Authorize]
        public IHttpActionResult PostUsersReservation(ReservationVM newReservation)
        {
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var reservation = ReservationServices.convertFromVM(newReservation, user);
            return Ok(reservation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool ReservationExists(int id)
        {
            return db.Reservations.Count(e => e.ID == id) > 0;
        }
    }
}