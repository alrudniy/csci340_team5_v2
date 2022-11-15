using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCteam5.Controllers
{
    public class Jaewoo_HelloWorldController : Controller
    {
        // 
        // GET: /Jaewoo_HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /Jaewoo_HelloWorld/Welcome/ 
        // Requires using System.Text.Encodings.Web;
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}