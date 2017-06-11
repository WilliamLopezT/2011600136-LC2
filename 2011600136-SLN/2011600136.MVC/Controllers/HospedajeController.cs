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
    public class HospedajeController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: Hospedaje
        public ActionResult Index()
        {
            return View(db.ServicioTuristicos.ToList());
        }

        // GET: Hospedaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospedaje hospedaje = db.Hospedajes.Find(id);
            if (hospedaje == null)
            {
                return HttpNotFound();
            }
            return View(hospedaje);
        }

        // GET: Hospedaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hospedaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioTuristicoId,NombreServicio,HospedajeId,NombreAlojamiento")] Hospedaje hospedaje)
        {
            if (ModelState.IsValid)
            {
                db.ServicioTuristicos.Add(hospedaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospedaje);
        }

        // GET: Hospedaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospedaje hospedaje = db.Hospedajes.Find(id);
            if (hospedaje == null)
            {
                return HttpNotFound();
            }
            return View(hospedaje);
        }

        // POST: Hospedaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioTuristicoId,NombreServicio,HospedajeId,NombreAlojamiento")] Hospedaje hospedaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospedaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospedaje);
        }

        // GET: Hospedaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hospedaje hospedaje = db.Hospedajes.Find(id);
            if (hospedaje == null)
            {
                return HttpNotFound();
            }
            return View(hospedaje);
        }

        // POST: Hospedaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hospedaje hospedaje = db.Hospedajes.Find(id);
            db.ServicioTuristicos.Remove(hospedaje);
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
