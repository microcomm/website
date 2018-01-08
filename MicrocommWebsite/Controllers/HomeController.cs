using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicrocommWebsite.Models;

namespace MicrocommWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("about")]
        public IActionResult About()
        {
            ViewData["Message"] = "The 'About' page";

            return View();
        }

        [Route("contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "The contact page.";

            return View();
        }


        public IActionResult Solutions()
        {
            ViewData["Message"] = "The 'Solutions' page.";

            return View();
        }

        [Route("blog")]
        public IActionResult Blog()
        {
            ViewData["Message"] = "The 'Blog' page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
