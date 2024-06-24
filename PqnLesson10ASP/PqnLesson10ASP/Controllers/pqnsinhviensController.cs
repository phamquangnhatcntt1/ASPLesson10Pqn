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
    public class pqnsinhviensController : Controller
    {
        private PqnK22CNTT1lesson10Entities db = new PqnK22CNTT1lesson10Entities();

        // GET: pqnsinhviens
        public ActionResult PqnIndex()
        {
            var pqnsinhvien = db.pqnsinhvien.Include(p => p.pqnkhoa);
            return View(pqnsinhvien.ToList());
        }

        // GET: pqnsinhviens/Details/5
        public ActionResult PqnDetails(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnsinhvien pqnsinhvien = db.pqnsinhvien.Find(id);
            if (pqnsinhvien == null)
            {
                return HttpNotFound();
            }
            return View(pqnsinhvien);
        }

        // GET: pqnsinhviens/Create
        public ActionResult PqnCreate()
        {
            ViewBag.PqnMaKH = new SelectList(db.pqnkhoa, "PqnMaKH", "PqnTenKH");
            return View();
        }

        // POST: pqnsinhviens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnCreate([Bind(Include = "PqnMaSV,PqnHoSV,PqnTenSV,PqnPhai,PqnNgaySinh,PqnNoiSinh,PqnMaKH,PqnHocBong,PqnDiemTrungBinh")] pqnsinhvien pqnsinhvien)
        {
            if (ModelState.IsValid)
            {
                db.pqnsinhvien.Add(pqnsinhvien);
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }

            ViewBag.PqnMaKH = new SelectList(db.pqnkhoa, "PqnMaKH", "PqnTenKH", pqnsinhvien.PqnMaKH);
            return View(pqnsinhvien);
        }

        // GET: pqnsinhviens/Edit/5
        public ActionResult PqnEdit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnsinhvien pqnsinhvien = db.pqnsinhvien.Find(id);
            if (pqnsinhvien == null)
            {
                return HttpNotFound();
            }
            ViewBag.PqnMaKH = new SelectList(db.pqnkhoa, "PqnMaKH", "PqnTenKH", pqnsinhvien.PqnMaKH);
            return View(pqnsinhvien);
        }

        // POST: pqnsinhviens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PqnEdit([Bind(Include = "PqnMaSV,PqnHoSV,PqnTenSV,PqnPhai,PqnNgaySinh,PqnNoiSinh,PqnMaKH,PqnHocBong,PqnDiemTrungBinh")] pqnsinhvien pqnsinhvien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pqnsinhvien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PqnIndex");
            }
            ViewBag.PqnMaKH = new SelectList(db.pqnkhoa, "PqnMaKH", "PqnTenKH", pqnsinhvien.PqnMaKH);
            return View(pqnsinhvien);
        }

        // GET: pqnsinhviens/Delete/5
        public ActionResult PqnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pqnsinhvien pqnsinhvien = db.pqnsinhvien.Find(id);
            if (pqnsinhvien == null)
            {
                return HttpNotFound();
            }
            return View(pqnsinhvien);
        }

        // POST: pqnsinhviens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult PqnDeleteConfirmed(string id)
        {
            pqnsinhvien pqnsinhvien = db.pqnsinhvien.Find(id);
            db.pqnsinhvien.Remove(pqnsinhvien);
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
