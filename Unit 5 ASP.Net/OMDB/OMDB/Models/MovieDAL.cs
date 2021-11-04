using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OMDB.Models
{
    public class MovieDAL
    {
        public MovieModel GetMovieData(string title)
        {
            string key = "a5f0675";
            string url = $"http://www.omdbapi.com/?apikey={key}&t={title}";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            MovieModel result = JsonConvert.DeserializeObject<MovieModel>(JSON);

            return result;
        }
    }
}
