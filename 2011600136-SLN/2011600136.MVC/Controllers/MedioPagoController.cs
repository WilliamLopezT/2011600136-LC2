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
    public class MedioPagoController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: MedioPago
        public ActionResult Index()
        {
            return View(db.MedioPagos.ToList());
        }

        // GET: MedioPago/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedioPago medioPago = db.MedioPagos.Find(id);
            if (medioPago == null)
            {
                return HttpNotFound();
            }
            return View(medioPago);
        }

        // GET: MedioPago/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MedioPago/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MedioPagoId,TipoPago,TipoTarjeta,NombreBanco")] MedioPago medioPago)
        {
            if (ModelState.IsValid)
            {
                db.MedioPagos.Add(medioPago);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medioPago);
        }

        // GET: MedioPago/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedioPago medioPago = db.MedioPagos.Find(id);
            if (medioPago == null)
            {
                return HttpNotFound();
            }
            return View(medioPago);
        }

        // POST: MedioPago/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MedioPagoId,TipoPago,TipoTarjeta,NombreBanco")] MedioPago medioPago)
        {
            if (ModelState.IsValid)
            {
                db.Entry(medioPago).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(medioPago);
        }

        // GET: MedioPago/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MedioPago medioPago = db.MedioPagos.Find(id);
            if (medioPago == null)
            {
                return HttpNotFound();
            }
            return View(medioPago);
        }

        // POST: MedioPago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MedioPago medioPago = db.MedioPagos.Find(id);
            db.MedioPagos.Remove(medioPago);
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
