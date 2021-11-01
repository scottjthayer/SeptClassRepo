using EfMvcDbFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EfMvcDbFirst.Controllers
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
            List<Event> result = null;
            using(EventDBContext context = new EventDBContext())
            {
                result = context.Events.ToList();
            }
            return View(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddEvent()
        {
            return View();
        }

        public IActionResult CreateEvent(Event e, string soldCheck)
        {
            if (soldCheck == "1")
            {
                e.SoldOut = true;
            }
            else
            {
                e.SoldOut = false;
            }
            using(EventDBContext context = new EventDBContext())
            {
                context.Events.Add(e);
                context.SaveChanges();
            }

            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
