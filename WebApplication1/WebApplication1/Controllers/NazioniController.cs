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
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class NazioniController : ApiController
    {
        private NazioniDBEntities db = new NazioniDBEntities();

        // GET: api/Nazioni
        public IQueryable<Nazioni> GetNazioni()
        {
            return db.Nazioni;
        }

        // GET: api/Nazioni/5
        [ResponseType(typeof(Nazioni))]
        public IHttpActionResult GetNazioni(string id)
        {
            Nazioni nazioni = db.Nazioni.Find(id);
            if (nazioni == null)
            {
                return NotFound();
            }

            return Ok(nazioni);
        }

        // PUT: api/Nazioni/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNazioni(string id, Nazioni nazioni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nazioni.NazioneId)
            {
                return BadRequest();
            }

            db.Entry(nazioni).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NazioniExists(id))
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

        // POST: api/Nazioni
        [ResponseType(typeof(Nazioni))]
        public IHttpActionResult PostNazioni(Nazioni nazioni)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Nazioni.Add(nazioni);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (NazioniExists(nazioni.NazioneId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = nazioni.NazioneId }, nazioni);
        }

        // DELETE: api/Nazioni/5
        [ResponseType(typeof(Nazioni))]
        public IHttpActionResult DeleteNazioni(string id)
        {
            Nazioni nazioni = db.Nazioni.Find(id);
            if (nazioni == null)
            {
                return NotFound();
            }

            db.Nazioni.Remove(nazioni);
            db.SaveChanges();

            return Ok(nazioni);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NazioniExists(string id)
        {
            return db.Nazioni.Count(e => e.NazioneId == id) > 0;
        }
    }
}