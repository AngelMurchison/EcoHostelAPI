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
    public class VolunteerTimeController : ApiController
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/VolunteerTime
        public IHttpActionResult GetvolunteerTimes()
        {
            return Ok(db.volunteerTimes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool VolunteerTimeExists(int id)
        {
            return db.volunteerTimes.Count(e => e.ID == id) > 0;
        }
    }
}