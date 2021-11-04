using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace APILecture.Models
{
    public class RedditDAL
    {
        public RedditModel GetData()
        {
            string url = $"https://www.reddit.com/r/aww/.json";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string JSON = reader.ReadToEnd();

            RedditModel result = JsonConvert.DeserializeObject<RedditModel>(JSON);

            return result;
        }
    }
}
