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
    public class PoslovnicasController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Poslovnicas
        public IQueryable<Poslovnica> GetPoslovnica()
        {
            return db.Poslovnica;
        }

        // GET: api/Poslovnicas/5
        [ResponseType(typeof(Poslovnica))]
        public async Task<IHttpActionResult> GetPoslovnica(int id)
        {
            Poslovnica poslovnica = await db.Poslovnica.FindAsync(id);
            if (poslovnica == null)
            {
                return NotFound();
            }

            return Ok(poslovnica);
        }

        // PUT: api/Poslovnicas/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPoslovnica(int id, Poslovnica poslovnica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != poslovnica.Id)
            {
                return BadRequest();
            }

            db.Entry(poslovnica).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PoslovnicaExists(id))
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

        // POST: api/Poslovnicas
        [ResponseType(typeof(Poslovnica))]
        public async Task<IHttpActionResult> PostPoslovnica(Poslovnica poslovnica)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Poslovnica.Add(poslovnica);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = poslovnica.Id }, poslovnica);
        }

        // DELETE: api/Poslovnicas/5
        [ResponseType(typeof(Poslovnica))]
        public async Task<IHttpActionResult> DeletePoslovnica(int id)
        {
            Poslovnica poslovnica = await db.Poslovnica.FindAsync(id);
            if (poslovnica == null)
            {
                return NotFound();
            }

            db.Poslovnica.Remove(poslovnica);
            await db.SaveChangesAsync();

            return Ok(poslovnica);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PoslovnicaExists(int id)
        {
            return db.Poslovnica.Count(e => e.Id == id) > 0;
        }
    }
}