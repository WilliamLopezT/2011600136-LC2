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
    public class TipoTransporteController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: TipoTransporte
        public ActionResult Index()
        {
            return View(db.TipoTransporte.ToList());
        }

        // GET: TipoTransporte/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransporte tipoTransporte = db.TipoTransporte.Find(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // GET: TipoTransporte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoTransporte/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoTransporteId,NombreTransporte")] TipoTransporte tipoTransporte)
        {
            if (ModelState.IsValid)
            {
                db.TipoTransporte.Add(tipoTransporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoTransporte);
        }

        // GET: TipoTransporte/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransporte tipoTransporte = db.TipoTransporte.Find(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // POST: TipoTransporte/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoTransporteId,NombreTransporte")] TipoTransporte tipoTransporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoTransporte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoTransporte);
        }

        // GET: TipoTransporte/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoTransporte tipoTransporte = db.TipoTransporte.Find(id);
            if (tipoTransporte == null)
            {
                return HttpNotFound();
            }
            return View(tipoTransporte);
        }

        // POST: TipoTransporte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoTransporte tipoTransporte = db.TipoTransporte.Find(id);
            db.TipoTransporte.Remove(tipoTransporte);
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
