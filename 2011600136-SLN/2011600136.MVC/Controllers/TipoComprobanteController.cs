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
    public class TipoComprobanteController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: TipoComprobante
        public ActionResult Index()
        {
            return View(db.Tipocomprobantes.ToList());
        }

        // GET: TipoComprobante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = db.Tipocomprobantes.Find(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // GET: TipoComprobante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoComprobante/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoComprobanteId,NombreComprobante,Fecha")] TipoComprobante tipoComprobante)
        {
            if (ModelState.IsValid)
            {
                db.Tipocomprobantes.Add(tipoComprobante);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoComprobante);
        }

        // GET: TipoComprobante/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = db.Tipocomprobantes.Find(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // POST: TipoComprobante/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoComprobanteId,NombreComprobante,Fecha")] TipoComprobante tipoComprobante)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoComprobante).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoComprobante);
        }

        // GET: TipoComprobante/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoComprobante tipoComprobante = db.Tipocomprobantes.Find(id);
            if (tipoComprobante == null)
            {
                return HttpNotFound();
            }
            return View(tipoComprobante);
        }

        // POST: TipoComprobante/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoComprobante tipoComprobante = db.Tipocomprobantes.Find(id);
            db.Tipocomprobantes.Remove(tipoComprobante);
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
