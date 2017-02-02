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
using System.Data.Entity.Migrations;

namespace EcoHostelAPI.Controllers
{
    public class ReservationsController : ApiController
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/Reservations
        public IHttpActionResult GetReservations()
        {
            return Ok(db.Reservations);
        }

        // GET: api/Reservations/
        [ResponseType(typeof(Reservation))]
        [Authorize]
        public IHttpActionResult GetReservation(string userid)
        {
            var user = User.Identity as System.Security.Claims.ClaimsIdentity;
            var usersname = user.Name;
            var usertoken = user.BootstrapContext as String;

            // claims has a bunch of properties, this is where the meta data from Auth0 will live
            foreach (var claim in user.Claims)
            {
                var key = claim.Type;
                var value = claim.Value;
            }

            var reservation = db.Reservations.Where(f => f.userID == usertoken).ToList();
            return Ok(reservation);
        }
        // POST api/<controller>
        public IHttpActionResult Post(Reservation Reservation)
        {
            db.Reservations.Add(Reservation);
            db.SaveChanges();
            return Ok();
        }

        // PUT api/<controller>/5
        public IHttpActionResult Put([FromUri]int id, Reservation Reservation)
        {
            db.Reservations.AddOrUpdate(Reservation);
            db.SaveChanges();
            return Ok();
        }

        // DELETE api/<controller>/5
        public IHttpActionResult Delete(int id)
        {
            var toDelete = db.Reservations.First(f => f.ID == id);
            db.Reservations.Remove(toDelete);
            db.SaveChanges();
            return Ok();
        }


        //// PUT: api/Reservations/5
        //[ResponseType(typeof(void))]
        //public IHttpActionResult PutReservation(int id, Reservation reservation)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != reservation.ID)
        //    {
        //        return BadRequest();
        //    }

        //    db.Entry(reservation).State = EntityState.Modified;

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ReservationExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //// POST: api/Reservations
        //[ResponseType(typeof(Reservation))]
        //public IHttpActionResult PostReservation(Reservation reservation)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.Reservations.Add(reservation);
        //    db.SaveChanges();

        //    return CreatedAtRoute("DefaultApi", new { id = reservation.ID }, reservation);
        //}

        // DELETE: api/Reservations/5
        //[ResponseType(typeof(Reservation))]
        //public IHttpActionResult DeleteReservation(int id)
        //{
        //    Reservation reservation = db.Reservations.Find(id);
        //    if (reservation == null)
        //    {
        //        return NotFound();
        //    }

        //    db.Reservations.Remove(reservation);
        //    db.SaveChanges();

        //    return Ok(reservation);
        //}

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