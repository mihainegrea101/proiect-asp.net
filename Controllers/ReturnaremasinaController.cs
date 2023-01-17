using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    
    public class ReturnaremasinaController : Controller
    {
        supermasinaEntities db = new supermasinaEntities();
        // GET: Returnaremasina
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Salvare(returnaremasina remasina )
        {
            if(ModelState.IsValid)
            {
                db.returnaremasina.Add( remasina );
                var masina = db.inrmasina.SingleOrDefault(e=>e.nrmasina==remasina.nrmasina);
                if(masina == null)
                    return HttpNotFound("Numarul masinii nu a fost gasit");
                masina.disponibilitate = "da";
                db.Entry(masina).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");

            }



            return View(remasina);
        }







        [HttpPost]
        public ActionResult Getid(string nrmasina)
        {
            var masinan = (from s in db.inchiriere
                           where s.masinaid == nrmasina
                           select new
                           {
                               DataInceput = s.sdata,
                               DataSfarsit = s.edate,
                               clientid = s.clientid,
                               nrmasina = s.masinaid,
                               pret = s.pret,
                               Timptrecut = SqlFunctions.DateDiff("day", s.edate, DateTime.Now)



                           }).ToArray();
            return Json(masinan,JsonRequestBehavior.AllowGet);
                           
                           
                           
                           
                           
                       
        }
    }
}