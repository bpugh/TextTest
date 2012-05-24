﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TextAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Please enter text to analyze.";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
