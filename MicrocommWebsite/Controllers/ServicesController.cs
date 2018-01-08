using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MicrocommWebsite.Models;


namespace MicrocommWebsite.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SoftwareDevelopment()
        {
            return View();
        }

        public IActionResult BusinessIntelligence()
        {
            return View();
        }

        public IActionResult InfrastructureEngineering()
        {
            return View();
        }

        public IActionResult NetworkDesign()
        {
            return View();
        }

        public IActionResult PortfolioManagement()
        {
            return View();
        }

    }
}