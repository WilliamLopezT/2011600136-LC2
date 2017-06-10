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
    public class CategoriaTransporteController : Controller
    {
        private _2011600136Context db = new _2011600136Context();

        // GET: CategoriaTransporte
        public ActionResult Index()
        {
            return View(db.CategoriaTransportes.ToList());
        }

        // GET: CategoriaTransporte/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTransporte categoriaTransporte = db.CategoriaTransportes.Find(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // GET: CategoriaTransporte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaTransporte/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoriaTransporteId")] CategoriaTransporte categoriaTransporte)
        {
            if (ModelState.IsValid)
            {
                db.CategoriaTransportes.Add(categoriaTransporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaTransporte);
        }

        // GET: CategoriaTransporte/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTransporte categoriaTransporte = db.CategoriaTransportes.Find(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // POST: CategoriaTransporte/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoriaTransporteId")] CategoriaTransporte categoriaTransporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaTransporte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaTransporte);
        }

        // GET: CategoriaTransporte/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaTransporte categoriaTransporte = db.CategoriaTransportes.Find(id);
            if (categoriaTransporte == null)
            {
                return HttpNotFound();
            }
            return View(categoriaTransporte);
        }

        // POST: CategoriaTransporte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaTransporte categoriaTransporte = db.CategoriaTransportes.Find(id);
            db.CategoriaTransportes.Remove(categoriaTransporte);
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
