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
    public class AlimentacionController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: Alimentacion
        public ActionResult Index()
        {
            return View(db.Alimentacions.ToList());
        }

        // GET: Alimentacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = db.Alimentacions.Find(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // GET: Alimentacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimentacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlimentacionId,NombreEstablecimiento")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                db.Alimentacions.Add(alimentacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alimentacion);
        }

        // GET: Alimentacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = db.Alimentacions.Find(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlimentacionId,NombreEstablecimiento")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alimentacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alimentacion);
        }

        // GET: Alimentacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = db.Alimentacions.Find(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alimentacion alimentacion = db.Alimentacions.Find(id);
            db.Alimentacions.Remove(alimentacion);
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
