using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class MasinaController : Controller
    {
        private supermasinaEntities db = new supermasinaEntities();

        // GET: Masina
        public ActionResult Index()
        {
            return View(db.inrmasina.ToList());
        }

        // GET: Masina/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inrmasina inrmasina = db.inrmasina.Find(id);
            if (inrmasina == null)
            {
                return HttpNotFound();
            }
            return View(inrmasina);
        }

        // GET: Masina/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Masina/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nrmasina,marca,model,disponibilitate")] inrmasina inrmasina)
        {
            if (ModelState.IsValid)
            {
                db.inrmasina.Add(inrmasina);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(inrmasina);
        }

        // GET: Masina/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inrmasina inrmasina = db.inrmasina.Find(id);
            if (inrmasina == null)
            {
                return HttpNotFound();
            }
            return View(inrmasina);
        }

        // POST: Masina/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nrmasina,marca,model,disponibilitate")] inrmasina inrmasina)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inrmasina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inrmasina);
        }

        // GET: Masina/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            inrmasina inrmasina = db.inrmasina.Find(id);
            if (inrmasina == null)
            {
                return HttpNotFound();
            }
            return View(inrmasina);
        }

        // POST: Masina/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            inrmasina inrmasina = db.inrmasina.Find(id);
            db.inrmasina.Remove(inrmasina);
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
