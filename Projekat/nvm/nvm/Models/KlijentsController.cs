using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace nvm.Models
{
    public class KlijentsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Klijents
        public IQueryable<Klijent> GetKlijent()
        {
            return db.Klijent;
        }

        // GET: api/Klijents/5
        [ResponseType(typeof(Klijent))]
        public async Task<IHttpActionResult> GetKlijent(int id)
        {
            Klijent klijent = await db.Klijent.FindAsync(id);
            if (klijent == null)
            {
                return NotFound();
            }

            return Ok(klijent);
        }

        // PUT: api/Klijents/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutKlijent(int id, Klijent klijent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != klijent.Id)
            {
                return BadRequest();
            }

            db.Entry(klijent).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KlijentExists(id))
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

        // POST: api/Klijents
        [ResponseType(typeof(Klijent))]
        public async Task<IHttpActionResult> PostKlijent(Klijent klijent)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Klijent.Add(klijent);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = klijent.Id }, klijent);
        }

        // DELETE: api/Klijents/5
        [ResponseType(typeof(Klijent))]
        public async Task<IHttpActionResult> DeleteKlijent(int id)
        {
            Klijent klijent = await db.Klijent.FindAsync(id);
            if (klijent == null)
            {
                return NotFound();
            }

            db.Klijent.Remove(klijent);
            await db.SaveChangesAsync();

            return Ok(klijent);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool KlijentExists(int id)
        {
            return db.Klijent.Count(e => e.Id == id) > 0;
        }
    }
}