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
    public class pqnketquasController : Controller
    {
        private PqnK22CNTT1lesson10Entities db = new PqnK22CNTT1lesson10Entities();

        // GET: pqnketquas
        public ActionResult PqnIndex()
        {
            var pqnketqua = db.pqnketqua.Include(p => p.pqnmonhoc).Include(p => p.pqnsinhvien);
            return View(pqnketqua.ToList());
        }

        // GET: pqnketquas/Details/5
        public ActionResult PqnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnketqua pqnketqua = db.pqnketqua.Find(id);
            if (pqnketqua == null)
            {
                return HttpNotFound();
            }
            return View(pqnketqua);
        }

        // GET: pqnketquas/Create
        public ActionResult PqnCreate()
        {
            ViewBag.PqnMaMH = new SelectList(db.pqnmonhoc, "PqnMaMH", "PqnTenMH");
            ViewBag.PqnMaSV = new SelectList(db.pqnsinhvien, "PqnMaSV", "PqnHoSV");
            return View();
        }

        // POST: pqnketquas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Pqnreate([Bind(Include = "PqnMaSV,PqnMaMH,Diem")] pqnketqua pqnketqua)
        {
            if (ModelState.IsValid)
            {
                db.pqnketqua.Add(pqnketqua);
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }

            ViewBag.PqnMaMH = new SelectList(db.pqnmonhoc, "PqnMaMH", "PqnTenMH", pqnketqua.PqnMaMH);
            ViewBag.PqnMaSV = new SelectList(db.pqnsinhvien, "PqnMaSV", "PqnHoSV", pqnketqua.PqnMaSV);
            return View(pqnketqua);
        }

        // GET: pqnketquas/Edit/5
        public ActionResult PqnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnketqua pqnketqua = db.pqnketqua.Find(id);
            if (pqnketqua == null)
            {
                return HttpNotFound();
            }
            ViewBag.PqnMaMH = new SelectList(db.pqnmonhoc, "PqnMaMH", "PqnTenMH", pqnketqua.PqnMaMH);
            ViewBag.PqnMaSV = new SelectList(db.pqnsinhvien, "PqnMaSV", "PqnHoSV", pqnketqua.PqnMaSV);
            return View(pqnketqua);
        }

        // POST: pqnketquas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnEdit([Bind(Include = "PqnMaSV,PqnMaMH,Diem")] pqnketqua pqnketqua)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqnketqua).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }
            ViewBag.PqnMaMH = new SelectList(db.pqnmonhoc, "PqnMaMH", "PqnTenMH", pqnketqua.PqnMaMH);
            ViewBag.PqnMaSV = new SelectList(db.pqnsinhvien, "PqnMaSV", "PqnHoSV", pqnketqua.PqnMaSV);
            return View(pqnketqua);
        }

        // GET: pqnketquas/Delete/5
        public ActionResult PqnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnketqua pqnketqua = db.pqnketqua.Find(id);
            if (pqnketqua == null)
            {
                return HttpNotFound();
            }
            return View(pqnketqua);
        }

        // POST: pqnketquas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult PqnDeleteConfirmed(string id)
        {
            pqnketqua pqnketqua = db.pqnketqua.Find(id);
            db.pqnketqua.Remove(pqnketqua);
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
