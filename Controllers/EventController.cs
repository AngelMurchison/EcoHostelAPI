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
        // GET: api/Event
        public IHttpActionResult GetEvents()
        {
            var db = new ApplicationDBContext();
            return Ok(db.Events);
        }
    }
}