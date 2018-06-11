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
    public class UposleniksController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Uposleniks
        public IQueryable<Uposlenik> GetUposlenik()
        {
            return db.Uposlenik;
        }

        // GET: api/Uposleniks/5
        [ResponseType(typeof(Uposlenik))]
        public async Task<IHttpActionResult> GetUposlenik(int id)
        {
            Uposlenik uposlenik = await db.Uposlenik.FindAsync(id);
            if (uposlenik == null)
            {
                return NotFound();
            }

            return Ok(uposlenik);
        }

        // PUT: api/Uposleniks/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUposlenik(int id, Uposlenik uposlenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != uposlenik.Id)
            {
                return BadRequest();
            }

            db.Entry(uposlenik).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UposlenikExists(id))
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

        // POST: api/Uposleniks
        [ResponseType(typeof(Uposlenik))]
        public async Task<IHttpActionResult> PostUposlenik(Uposlenik uposlenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Uposlenik.Add(uposlenik);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = uposlenik.Id }, uposlenik);
        }

        // DELETE: api/Uposleniks/5
        [ResponseType(typeof(Uposlenik))]
        public async Task<IHttpActionResult> DeleteUposlenik(int id)
        {
            Uposlenik uposlenik = await db.Uposlenik.FindAsync(id);
            if (uposlenik == null)
            {
                return NotFound();
            }

            db.Uposlenik.Remove(uposlenik);
            await db.SaveChangesAsync();

            return Ok(uposlenik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UposlenikExists(int id)
        {
            return db.Uposlenik.Count(e => e.Id == id) > 0;
        }
    }
}