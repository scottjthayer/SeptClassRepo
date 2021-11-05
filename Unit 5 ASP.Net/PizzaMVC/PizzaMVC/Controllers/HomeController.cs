using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaMVC.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AddPizza()
        {
            return View();
        }

        public IActionResult CreatePizza(string Name, int Popularity)
        {
            using(PizzaDBContext context = new PizzaDBContext())
            {
                Pizza newPizza = new Pizza() { Name = Name, Popularity = Popularity };
                context.Pizzas.Add(newPizza);
                context.SaveChanges();
            }
            return RedirectToAction("PizzaDisplay");
        }

        public IActionResult PizzaDisplay()
        {
            List<Pizza> result = null;
            using(PizzaDBContext context = new PizzaDBContext())
            {
                result = context.Pizzas.ToList();
            }
            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
