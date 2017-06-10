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
    public class ServicioHospedajeController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: ServicioHospedaje
        public ActionResult Index()
        {
            return View(db.ServicioHospedajes.ToList());
        }

        // GET: ServicioHospedaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioHospedaje servicioHospedaje = db.ServicioHospedajes.Find(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // GET: ServicioHospedaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicioHospedaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ServicioHospedajeId,Comida,Bebidas,Postre")] ServicioHospedaje servicioHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.ServicioHospedajes.Add(servicioHospedaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(servicioHospedaje);
        }

        // GET: ServicioHospedaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioHospedaje servicioHospedaje = db.ServicioHospedajes.Find(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // POST: ServicioHospedaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ServicioHospedajeId,Comida,Bebidas,Postre")] ServicioHospedaje servicioHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(servicioHospedaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(servicioHospedaje);
        }

        // GET: ServicioHospedaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServicioHospedaje servicioHospedaje = db.ServicioHospedajes.Find(id);
            if (servicioHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(servicioHospedaje);
        }

        // POST: ServicioHospedaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServicioHospedaje servicioHospedaje = db.ServicioHospedajes.Find(id);
            db.ServicioHospedajes.Remove(servicioHospedaje);
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
