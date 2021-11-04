using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OMDB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//9c14ad2c

namespace OMDB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieDAL movieDAL = new MovieDAL();

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

        public IActionResult MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSearch(string title)
        {
            MovieModel result = movieDAL.GetMovieData(title);
            return View(result);
        }

        public IActionResult MovieNight()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieNight(string title1, string title2, string title3)
        {
            MovieModel result1 = movieDAL.GetMovieData(title1);
            MovieModel result2 = movieDAL.GetMovieData(title2);
            MovieModel result3 = movieDAL.GetMovieData(title3);

            List<MovieModel> result = new List<MovieModel>()
            {
                result1, result2, result3
            };

            return View(result);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
