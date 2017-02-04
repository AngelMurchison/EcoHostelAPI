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

namespace EcoHostelAPI.Controllers
{
    public class UserController : ApiController
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/User
        [Authorize]
        public IHttpActionResult GetUsersReservation()
        {
            // TODO: Add collection variables for username, email, phone, id from user.claims. Use user.claims.type to step through and grab each one.
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var userid = user.Claims.First(f => f.Type == "user_id").Value;
            var reservation = db.Reservations.LastOrDefault(f => f.userID == userid);

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