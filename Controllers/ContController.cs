using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ContController : Controller
    {
        supermasinaEntities entity = new supermasinaEntities(); 
        // GET: Account
        public ActionResult Conectare()
        {
            return View();
        }
        public ActionResult Inregistrare()
        {
            return View();
        }
        public ActionResult Deconectare()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Conectare");
        }
        [HttpPost]
        public ActionResult Conectare(ConectareViewModel data)
        {
            bool existautilizator = entity.Utilizator.Any(x => x.Email == data.Email && x.Parola == data.Parola);
            Utilizator u = entity.Utilizator.FirstOrDefault(x => x.Email == data.Email && x.Parola == data.Parola);
            if (existautilizator)
            {
                FormsAuthentication.SetAuthCookie(u.NumeUtilizator, false);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "Numele de utilizator sau parola sunt gresite");

            return View();
        }
        [HttpPost]
        public ActionResult Inregistrare(Utilizator utilizatorinfo)
        {
            entity.Utilizator.Add(utilizatorinfo);
            entity.SaveChanges();
            return RedirectToAction("Conectare");

            return View();
        }
        
    }
}