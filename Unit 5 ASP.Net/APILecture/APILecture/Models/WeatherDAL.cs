using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APILecture.Models
{
    public class WeatherDAL
    {
        public WeatherModel GetData(string city)
        {
            string key = "88c3f0347b09dd80d4cd7bd5663e240a";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={key}&units=metric";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            WeatherModel weather = JsonConvert.DeserializeObject<WeatherModel>(JSON);

            return weather;
        }
    }
}
