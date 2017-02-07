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

        // GET: api/Reservation
        [Authorize]
        [ResponseType(typeof (ReservationVM))]
        public IHttpActionResult GetUsersReservation()
        {
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userid = user.Name;
            var db = new ApplicationDBContext();
            var reservation = db.Reservations.OrderByDescending(f => f.startDate).FirstOrDefault();
            if (reservation==null)
            {
                return Ok(new ReservationVM()
                {
                    found = false
                });
            }
            var vm = Services.ReservationServices.convertToVM(reservation);

            return Ok(vm);
        }

        // POST: api/Reservation
        [Authorize]
        // TODO: Change how it stores userid why is this not hitting the database.
        public IHttpActionResult PostUsersReservation(ReservationVM newReservation)
        {
            var db = new ApplicationDBContext();
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var reservation = ReservationServices.convertFromVM(newReservation, user);
            db.Reservations.AddOrUpdate(reservation);
            db.SaveChanges();
            return Ok(reservation);
        }
    }
}