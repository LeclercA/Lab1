using System;
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

        public string Index()
        {
            return "Ceci est mon action par <b>défaut</b>...";
        }

        // 
        // GET: /HelloWorld/Welcome/ 


        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Bonjour " + name + ", NumTimes is: " + numTimes);
        }
    }
}
