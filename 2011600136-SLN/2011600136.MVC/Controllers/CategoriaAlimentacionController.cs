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
    public class CategoriaAlimentacionController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: CategoriaAlimentacion
        public ActionResult Index()
        {
            return View(db.CategoriaAlimentacions.ToList());
        }

        // GET: CategoriaAlimentacion/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaAlimentacion categoriaAlimentacion = db.CategoriaAlimentacions.Find(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacion/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaAlimentacion/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaAlimentacionId")] CategoriaAlimentacion categoriaAlimentacion)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaAlimentacions.Add(categoriaAlimentacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacion/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaAlimentacion categoriaAlimentacion = db.CategoriaAlimentacions.Find(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // POST: CategoriaAlimentacion/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaAlimentacionId")] CategoriaAlimentacion categoriaAlimentacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaAlimentacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaAlimentacion);
        }

        // GET: CategoriaAlimentacion/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaAlimentacion categoriaAlimentacion = db.CategoriaAlimentacions.Find(id);
            if (categoriaAlimentacion == null)
            {
                return HttpNotFound();
            }
            return View(categoriaAlimentacion);
        }

        // POST: CategoriaAlimentacion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaAlimentacion categoriaAlimentacion = db.CategoriaAlimentacions.Find(id);
            db.CategoriaAlimentacions.Remove(categoriaAlimentacion);
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
