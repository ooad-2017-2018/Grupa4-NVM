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
    public class ZahtjevZaKreditsController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/ZahtjevZaKredits
        public IQueryable<ZahtjevZaKredit> GetZahtjevZaKredit()
        {
            return db.ZahtjevZaKredit;
        }

        // GET: api/ZahtjevZaKredits/5
        [ResponseType(typeof(ZahtjevZaKredit))]
        public async Task<IHttpActionResult> GetZahtjevZaKredit(int id)
        {
            ZahtjevZaKredit zahtjevZaKredit = await db.ZahtjevZaKredit.FindAsync(id);
            if (zahtjevZaKredit == null)
            {
                return NotFound();
            }

            return Ok(zahtjevZaKredit);
        }

        // PUT: api/ZahtjevZaKredits/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutZahtjevZaKredit(int id, ZahtjevZaKredit zahtjevZaKredit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != zahtjevZaKredit.Id)
            {
                return BadRequest();
            }

            db.Entry(zahtjevZaKredit).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ZahtjevZaKreditExists(id))
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

        // POST: api/ZahtjevZaKredits
        [ResponseType(typeof(ZahtjevZaKredit))]
        public async Task<IHttpActionResult> PostZahtjevZaKredit(ZahtjevZaKredit zahtjevZaKredit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.ZahtjevZaKredit.Add(zahtjevZaKredit);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = zahtjevZaKredit.Id }, zahtjevZaKredit);
        }

        // DELETE: api/ZahtjevZaKredits/5
        [ResponseType(typeof(ZahtjevZaKredit))]
        public async Task<IHttpActionResult> DeleteZahtjevZaKredit(int id)
        {
            ZahtjevZaKredit zahtjevZaKredit = await db.ZahtjevZaKredit.FindAsync(id);
            if (zahtjevZaKredit == null)
            {
                return NotFound();
            }

            db.ZahtjevZaKredit.Remove(zahtjevZaKredit);
            await db.SaveChangesAsync();

            return Ok(zahtjevZaKredit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ZahtjevZaKreditExists(int id)
        {
            return db.ZahtjevZaKredit.Count(e => e.Id == id) > 0;
        }
    }
}