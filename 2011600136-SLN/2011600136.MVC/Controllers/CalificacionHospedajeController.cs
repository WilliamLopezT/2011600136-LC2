using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2011600136_ENT.Entities;
using _2011600136_PER;

namespace _2011600136.MVC.Controllers
{
    public class CalificacionHospedajeController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: CalificacionHospedaje
        public ActionResult Index()
        {
            return View(db.CalificacionHospedajes.ToList());
        }

        // GET: CalificacionHospedaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CalificacionHospedaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CalificacionHospedajeId,DescripcionCalificacion")] CalificacionHospedaje calificacionHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.CalificacionHospedajes.Add(calificacionHospedaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // POST: CalificacionHospedaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CalificacionHospedajeId,DescripcionCalificacion")] CalificacionHospedaje calificacionHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificacionHospedaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(calificacionHospedaje);
        }

        // GET: CalificacionHospedaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            if (calificacionHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(calificacionHospedaje);
        }

        // POST: CalificacionHospedaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CalificacionHospedaje calificacionHospedaje = db.CalificacionHospedajes.Find(id);
            db.CalificacionHospedajes.Remove(calificacionHospedaje);
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
