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
    public class pqnkhoasController : Controller
    {
        private PqnK22CNTT1lesson10Entities db = new PqnK22CNTT1lesson10Entities();

        // GET: pqnkhoas
        public ActionResult PqnIndex()
        {
            return View(db.pqnkhoa.ToList());
        }

        // GET: pqnkhoas/Details/5
        public ActionResult PqnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnkhoa pqnkhoa = db.pqnkhoa.Find(id);
            if (pqnkhoa == null)
            {
                return HttpNotFound();
            }
            return View(pqnkhoa);
        }

        // GET: pqnkhoas/Create
        public ActionResult PqnCreate()
        {
            return View();
        }

        // POST: pqnkhoas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnCreate([Bind(Include = "PqnMaKH,PqnTenKH")] pqnkhoa pqnkhoa)
        {
            if (ModelState.IsValid)
            {
                db.pqnkhoa.Add(pqnkhoa);
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }

            return View(pqnkhoa);
        }

        // GET: pqnkhoas/Edit/5
        public ActionResult PqnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnkhoa pqnkhoa = db.pqnkhoa.Find(id);
            if (pqnkhoa == null)
            {
                return HttpNotFound();
            }
            return View(pqnkhoa);
        }

        // POST: pqnkhoas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnEdit([Bind(Include = "PqnMaKH,PqnTenKH")] pqnkhoa pqnkhoa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqnkhoa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }
            return View(pqnkhoa);
        }

        // GET: pqnkhoas/Delete/5
        public ActionResult PqnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnkhoa pqnkhoa = db.pqnkhoa.Find(id);
            if (pqnkhoa == null)
            {
                return HttpNotFound();
            }
            return View(pqnkhoa);
        }

        // POST: pqnkhoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult PqnDeleteConfirmed(string id)
        {
            pqnkhoa pqnkhoa = db.pqnkhoa.Find(id);
            db.pqnkhoa.Remove(pqnkhoa);
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
