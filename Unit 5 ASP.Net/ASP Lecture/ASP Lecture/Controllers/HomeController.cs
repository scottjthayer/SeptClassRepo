using ASP_Lecture.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Lecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["Name"] = "Justin";
            ViewBag.Age = 24;
            //Session["Hometown"] = "Wyoming";
            //Response.Cookies["Username"].Value = "1";
            HttpContext.Response.Cookies.Append("User", "Jeo");
            //HttpContext.Session.SetString("Class", "Full Stack C#");

            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["User"] = HttpContext.Request.Cookies["User"];
            //ViewData["Class"] = HttpContext.Session.GetString("Class");
            return View();
        }

        public IActionResult Secret()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Result(int Num1, int Num2)
        {
            ViewData["Result"] = Num1 + Num2;
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
