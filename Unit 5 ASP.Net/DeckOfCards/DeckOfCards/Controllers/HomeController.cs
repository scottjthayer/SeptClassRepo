using DeckOfCards.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private CardDAL cardDAL = new CardDAL();

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

        public IActionResult CreateDeck()
        {
            DeckModel result = cardDAL.GetDeck();
            cardDAL.ShuffleDeck(result.deck_id);
            HttpContext.Response.Cookies.Append("DeckID", result.deck_id);
            return RedirectToAction("Cards");
        }

        public IActionResult Cards()
        {
            string deckid = HttpContext.Request.Cookies["DeckID"];
            CardModel result = cardDAL.GetCards(deckid);
            if(result.cards.Length < 5)
            {
                cardDAL.ShuffleDeck(deckid);
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
