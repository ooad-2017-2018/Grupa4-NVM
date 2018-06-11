using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MikrokreditnaOrganizacijaNVM.Models;

namespace MikrokreditnaOrganizacijaNVM.Controllers
{
    public class UposleniksController : Controller
    {
        private OOADNVMContext db = new OOADNVMContext();

        // GET: Uposleniks
        public ActionResult Index()
        {
            return View(db.Uposlenici.ToList());
        }

        // GET: Uposleniks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenici.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // GET: Uposleniks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Uposleniks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,fourSqaureId,Ime,Prezime,JMBG,BrTel,Adresa,Username,Password")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Uposlenici.Add(uposlenik);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(uposlenik);
        }

        // GET: Uposleniks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenici.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposleniks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,fourSqaureId,Ime,Prezime,JMBG,BrTel,Adresa,Username,Password")] Uposlenik uposlenik)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uposlenik).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(uposlenik);
        }

        // GET: Uposleniks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Uposlenik uposlenik = db.Uposlenici.Find(id);
            if (uposlenik == null)
            {
                return HttpNotFound();
            }
            return View(uposlenik);
        }

        // POST: Uposleniks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Uposlenik uposlenik = db.Uposlenici.Find(id);
            db.Uposlenici.Remove(uposlenik);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
