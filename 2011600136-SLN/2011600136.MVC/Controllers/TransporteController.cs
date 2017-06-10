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
    public class TransporteController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: Transporte
        public ActionResult Index()
        {
            return View(db.ServicioTuristicos.ToList());
        }

        // GET: Transporte/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.ServicioTuristicos.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // GET: Transporte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transporte/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoId,NombreServicio,TransporteId,NombreEmpresa")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                db.ServicioTuristicos.Add(transporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transporte);
        }

        // GET: Transporte/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.ServicioTuristicos.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // POST: Transporte/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoId,NombreServicio,TransporteId,NombreEmpresa")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transporte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transporte);
        }

        // GET: Transporte/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.ServicioTuristicos.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // POST: Transporte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transporte transporte = db.ServicioTuristicos.Find(id);
            db.ServicioTuristicos.Remove(transporte);
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
