using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PqnLesson10ASP.Models;

namespace PqnLesson10ASP.Controllers
{
    public class pqnmonhocsController : Controller
    {
        private PqnK22CNTT1lesson10Entities db = new PqnK22CNTT1lesson10Entities();

        // GET: pqnmonhocs
        public ActionResult PqnIndex()
        {
            return View(db.pqnmonhoc.ToList());
        }

        // GET: pqnmonhocs/Details/5
        public ActionResult PqnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnmonhoc pqnmonhoc = db.pqnmonhoc.Find(id);
            if (pqnmonhoc == null)
            {
                return HttpNotFound();
            }
            return View(pqnmonhoc);
        }

        // GET: pqnmonhocs/Create
        public ActionResult PqnCreate()
        {
            return View();
        }

        // POST: pqnmonhocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnCreate([Bind(Include = "PqnMaMH,PqnTenMH,Sotiet")] pqnmonhoc pqnmonhoc)
        {
            if (ModelState.IsValid)
            {
                db.pqnmonhoc.Add(pqnmonhoc);
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }

            return View(pqnmonhoc);
        }

        // GET: pqnmonhocs/Edit/5
        public ActionResult PqnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnmonhoc pqnmonhoc = db.pqnmonhoc.Find(id);
            if (pqnmonhoc == null)
            {
                return HttpNotFound();
            }
            return View(pqnmonhoc);
        }

        // POST: pqnmonhocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnEdit([Bind(Include = "PqnMaMH,PqnTenMH,Sotiet")] pqnmonhoc pqnmonhoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqnmonhoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }
            return View(pqnmonhoc);
        }

        // GET: pqnmonhocs/Delete/5
        public ActionResult PqnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnmonhoc pqnmonhoc = db.pqnmonhoc.Find(id);
            if (pqnmonhoc == null)
            {
                return HttpNotFound();
            }
            return View(pqnmonhoc);
        }

        // POST: pqnmonhocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult PqnDeleteConfirmed(string id)
        {
            pqnmonhoc pqnmonhoc = db.pqnmonhoc.Find(id);
            db.pqnmonhoc.Remove(pqnmonhoc);
            db.SaveChanges();
            return RedirectToAction("PqnIndex");
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
