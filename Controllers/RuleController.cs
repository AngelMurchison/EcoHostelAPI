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
    public class RuleController : ApiController
    {
        private ApplicationDBContext db = new ApplicationDBContext();

        // GET: api/Rule
        public IHttpActionResult GetRules()
        {
            return Ok(db.Rules);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool RuleExists(int id)
        {
            return db.Rules.Count(e => e.ID == id) > 0;
        }
    }
}