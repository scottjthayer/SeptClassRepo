using CoffeeShop2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop2.Controllers
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

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            User result = null;
            using (CoffeeDBContext context = new CoffeeDBContext())
            {
                result = context.Users.ToList().Find(u => u.Id == id);
            }
            return View(result);
        }

        public IActionResult UserList()
        {
            List<User> result = null;
            using (CoffeeDBContext context = new CoffeeDBContext())
            {
                result = context.Users.ToList();
            }
            return View(result);
        }

        public IActionResult CreateUser(User u)
        {
            using(CoffeeDBContext context = new CoffeeDBContext())
            {
                context.Users.Add(u);
                context.SaveChanges();
            }
            return RedirectToAction("UserList");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
