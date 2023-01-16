﻿using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
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
    }
}