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
    public class ClassController : ApiController
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/Class
        public IHttpActionResult GetClasses()
        {
            return Ok(db.Classes);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool ClassExists(int id)
        {
            return db.Classes.Count(e => e.ID == id) > 0;
        }
    }
}