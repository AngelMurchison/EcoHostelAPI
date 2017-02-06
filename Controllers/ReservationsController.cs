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
        public static ApplicationDBContext db = new ApplicationDBContext();

        //// GET: api/Reservations
        //[Authorize]
        //public IHttpActionResult GetReservations()
        //{
        //    return Ok(db.Reservations);
        //}

        //// POST api/<controller>
        //[Authorize]
        //public IHttpActionResult Post(Reservation Reservation)
        //{
            
        //    var user = User.Identity as System.Security.Claims.ClaimsIdentity;
        //    var userExists = UserServices.verifyUser(user);

        //    if (!userExists)
        //    {
        //        var newuser = UserServices.createUser(user);
        //        Reservation.user = newuser;
        //        Reservation.userID = newuser.ID;
        //    }

        //    db.Reservations.Add(Reservation);
        //    db.SaveChanges();
        //    return Ok(Reservation);
        //}

        //// PUT api/<controller>/5
        //[Authorize]
        //public IHttpActionResult Put([FromUri]int id, Reservation Reservation)
        //{
        //    db.Reservations.AddOrUpdate(Reservation);
        //    db.SaveChanges();
        //    return Ok();
        //}

        //// DELETE api/<controller>/5
        //[Authorize]
        //public IHttpActionResult Delete(int id)
        //{
        //    var toDelete = db.Reservations.First(f => f.ID == id);
        //    db.Reservations.Remove(toDelete);
        //    db.SaveChanges();
        //    return Ok();
        //}


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