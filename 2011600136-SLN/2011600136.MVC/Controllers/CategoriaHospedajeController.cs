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
    public class CategoriaHospedajeController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: CategoriaHospedaje
        public ActionResult Index()
        {
            return View(db.CategoriaHospedajes.ToList());
        }

        // GET: CategoriaHospedaje/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaHospedaje categoriaHospedaje = db.CategoriaHospedajes.Find(id);
            if (categoriaHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaHospedaje);
        }

        // GET: CategoriaHospedaje/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaHospedaje/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaHospedajeId")] CategoriaHospedaje categoriaHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaHospedajes.Add(categoriaHospedaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaHospedaje);
        }

        // GET: CategoriaHospedaje/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaHospedaje categoriaHospedaje = db.CategoriaHospedajes.Find(id);
            if (categoriaHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaHospedaje);
        }

        // POST: CategoriaHospedaje/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaHospedajeId")] CategoriaHospedaje categoriaHospedaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaHospedaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaHospedaje);
        }

        // GET: CategoriaHospedaje/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaHospedaje categoriaHospedaje = db.CategoriaHospedajes.Find(id);
            if (categoriaHospedaje == null)
            {
                return HttpNotFound();
            }
            return View(categoriaHospedaje);
        }

        // POST: CategoriaHospedaje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaHospedaje categoriaHospedaje = db.CategoriaHospedajes.Find(id);
            db.CategoriaHospedajes.Remove(categoriaHospedaje);
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
