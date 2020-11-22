﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SeyahatSitem.Models.Sınıflar;

namespace SeyahatSitem.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
       
        public ActionResult Index()
        {
            var degerler = c.Blogs.ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.Blogs.OrderByDescending(x=>x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var deger = c.Blogs.Where(x => x.ID == 5).ToList();
            return PartialView(deger);
        }
        public PartialViewResult Partial3()
        {
            var degerlerr = c.Blogs.Take(3).ToList();
            return PartialView(degerlerr);
        }
        public PartialViewResult Partial4()
        {
            var deger = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(deger);
        }
    }
}