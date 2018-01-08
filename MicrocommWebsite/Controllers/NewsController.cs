using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MicrocommWebsite.Controllers
{
    public class NewsController : Controller
    {
        [Route("news")]
        public IActionResult Index()
        {
            return View();
        }
    }
}