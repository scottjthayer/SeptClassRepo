using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CardDemo.Models
{
    public class CardDAL
    {
        public Deck GetDeck()
        {
            string url = $"https://deckofcardsapi.com/api/deck/new/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            Deck result = JsonConvert.DeserializeObject<Deck>(JSON);

            return result;
        }

        public void ShuffleDeck(string id)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{id}/shuffle/";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

        public CardSet GetCards(string id, int keepCards)
        {
            string url = $"https://deckofcardsapi.com/api/deck/{id}/draw/?count={5-keepCards}";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            CardSet result = JsonConvert.DeserializeObject<CardSet>(JSON);

            return result;
        }
    }
}
