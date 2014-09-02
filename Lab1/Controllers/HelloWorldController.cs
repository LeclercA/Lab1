﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 

        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 


        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Bonjour jeune légume nommé " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}
