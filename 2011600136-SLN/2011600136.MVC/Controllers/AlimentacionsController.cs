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
    public class AlimentacionsController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: Alimentacions
        public ActionResult Index()
        {
            return View(db.ServicioTuristicos.ToList());
        }

        // GET: Alimentacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = db.ServicioTuristicos.Find(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // GET: Alimentacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimentacions/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoId,NombreServicio,AlimentacionId,NombreEstablecimiento")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                db.ServicioTuristicos.Add(alimentacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alimentacion);
        }

        // GET: Alimentacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = db.ServicioTuristicos.Find(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacions/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoId,NombreServicio,AlimentacionId,NombreEstablecimiento")] Alimentacion alimentacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alimentacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alimentacion);
        }

        // GET: Alimentacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alimentacion alimentacion = db.ServicioTuristicos.Find(id);
            if (alimentacion == null)
            {
                return HttpNotFound();
            }
            return View(alimentacion);
        }

        // POST: Alimentacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alimentacion alimentacion = db.ServicioTuristicos.Find(id);
            db.ServicioTuristicos.Remove(alimentacion);
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
