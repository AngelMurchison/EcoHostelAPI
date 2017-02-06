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
    public class EventController : ApiController
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/Event
        public IHttpActionResult GetEvents()
        {
            return Ok(db.Events);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool EventExists(int id)
        {
            return db.Events.Count(e => e.ID == id) > 0;
        }
    }
}