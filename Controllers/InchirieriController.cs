using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class InchirieriController : Controller
    {
        supermasinaEntities db=new supermasinaEntities();
        // GET: Inchirieri
        public ActionResult Index()
        {
            var rezultat = (from r in db.inchiriere join c in db.inrmasina on r.masinaid equals c.nrmasina
            select new InchiriereViewModel
            {
                id = r.id,
                masinaid = r.masinaid,
                clientid = r.clientid,
                pret = r.pret,
                sdata = r.sdata,
                edate = r.edate,
                disponibilitate = c.disponibilitate
                
                
            }).ToList();
            
            
            
            




            return View(rezultat);
        }
        [HttpGet]
        public ActionResult Getmasina()
        {
            var masina= db.inrmasina.ToList();
            return Json(masina,JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Getid(int id)
        {
            var client = (from s in db.client where s.id == id select s.numeclient).ToList();
            return Json(client, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public ActionResult Getavil(string nrmasina)
        {
            var avabilitatemasina = (from s in db.inrmasina where s.nrmasina == nrmasina select s.disponibilitate).FirstOrDefault();
            return Json(avabilitatemasina, JsonRequestBehavior.AllowGet);
        }









        [HttpPost]
        public ActionResult Salvare(inchiriere inchirieri)
        {
            if (ModelState.IsValid)
            {
                db.inchiriere.Add(inchirieri);
                var masina = db.inrmasina.SingleOrDefault(e=>e.nrmasina==inchirieri.masinaid);
                if (masina == null)
                    return HttpNotFound("Numarul masinii nu este valid");
                masina.disponibilitate = "nu";
                db.Entry(masina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(inchirieri) ;
        }

    }
}