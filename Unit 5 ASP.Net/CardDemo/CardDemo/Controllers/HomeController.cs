using CardDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace CardDemo.Controllers
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
            
            Deck cards = cardDAL.GetDeck();
            cardDAL.ShuffleDeck(cards.deck_id);
            CardSet cset = cardDAL.GetCards(cards.deck_id,0);

            return View(cset);
        }
        [HttpPost]
        public IActionResult Index(string deckId, List<int> keepIndex, List<Card> hand)
        {
            List<Card> keepCards = new List<Card>();

            foreach(int i in keepIndex)
            {
                keepCards.Add(hand[i]);
            }

            // only need to draw for each card you discarded
            CardSet cset = cardDAL.GetCards(deckId,keepCards.Count);

            // Add the old hand back
            if (keepCards != null)
            {
                cset.cards.InsertRange(0,keepCards);
            }

            return View(cset);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
