using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using TabelaCervejaAPI;
using TabelaCervejaAPI.Models;

namespace TabelaCervejaAPI.Controllers
{
    public class EstiloCervejaController : ApiController
    {
        private ContextoDB db = new ContextoDB();

        // GET: api/EstiloCerveja
        [HttpGet]
        public IQueryable<EstiloCerveja> GetEstiloCerveja()
        {
            return  db.EstiloCerveja;
        }

        // GET: api/EstiloCerveja/5
        [ResponseType(typeof(EstiloCerveja))]
        public IHttpActionResult GetEstiloCerveja(int id)
        {
            EstiloCerveja estiloCerveja = db.EstiloCerveja.Find(id);
            if (estiloCerveja == null)
            {
                return NotFound();
            }

            return Ok(estiloCerveja);
        }

        // PUT: api/EstiloCerveja/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEstiloCerveja(int id, EstiloCerveja estiloCerveja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != estiloCerveja.IDEstilo)
            {
                return BadRequest();
            }

            db.Entry(estiloCerveja).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstiloCervejaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EstiloCerveja
        [ResponseType(typeof(EstiloCerveja))]
        public IHttpActionResult PostEstiloCerveja(EstiloCerveja estiloCerveja)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EstiloCerveja.Add(estiloCerveja);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = estiloCerveja.IDEstilo }, estiloCerveja);
        }

        // DELETE: api/EstiloCerveja/5
        [ResponseType(typeof(EstiloCerveja))]
        public IHttpActionResult DeleteEstiloCerveja(int id)
        {
            EstiloCerveja estiloCerveja = db.EstiloCerveja.Find(id);
            if (estiloCerveja == null)
            {
                return NotFound();
            }

            db.EstiloCerveja.Remove(estiloCerveja);
            db.SaveChanges();

            return Ok(estiloCerveja);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EstiloCervejaExists(int id)
        {
            return db.EstiloCerveja.Count(e => e.IDEstilo == id) > 0;
        }
    }
}