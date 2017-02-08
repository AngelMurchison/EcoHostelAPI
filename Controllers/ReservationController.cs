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
        //TODO: MAKE A DELETE FUNCTION

        // GET: api/reservation
        [Authorize]
        [ResponseType(typeof (ReservationVM))]
        public IHttpActionResult Get()
        {
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userid = user.Name;
            var db = new ApplicationDBContext();
            var reservation = db.Reservations.OrderByDescending(f => f.startDate).FirstOrDefault(f => f.userID == user.Name);
            if (reservation == null)
            {
                return Ok(new ReservationVM()
                {
                    found = false
                });
            }
            var vm = Services.ReservationServices.convertToVM(reservation);
            return Ok(vm);
        }

        // POST: api/reservation
        [Authorize]
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult Post([FromBody]ReservationVM vm)
        {
            var db = new ApplicationDBContext();
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var reservation = ReservationServices.convertFromVM(vm, user);
            db.Reservations.AddOrUpdate(reservation);
            db.SaveChanges();
            return Ok(reservation);
        }

        // Delete: api/reservation
        // TODO: Test this controller.
        [Authorize]
        [ResponseType(typeof(void))]
        public IHttpActionResult Delete()
        {
            var db = new ApplicationDBContext();
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var reservation = db.Reservations.OrderByDescending(f => f.startDate).FirstOrDefault(f => f.userID == user.Name);
            if (reservation == null)
            {
                return Ok(new ReservationVM()
                {
                    found = false
                });
            }
            db.Reservations.Remove(reservation);
            return Ok("Removed successfully.");
        }
    }
}