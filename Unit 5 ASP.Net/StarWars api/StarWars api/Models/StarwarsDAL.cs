using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace StarWars_api.Models
{
    public class StarwarsDAL
    {
        public StarwarsModel GetCharacters(string name)
        {
            string url = $"https://swapi.dev/api/people/?search={name}";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            StarwarsModel result = JsonConvert.DeserializeObject<StarwarsModel>(JSON);

            return result;
        }
    }
}
