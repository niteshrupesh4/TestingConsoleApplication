using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace TestingConsoleApplication
{

    public class Provider
    {
        [JsonProperty("source")]
        public string source { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("pubDate")]
        public DateTime pubDate { get; set; }

    }

    public class Root
    {
        [JsonProperty("matches")]
        public List<Match> matches { get; set; }
        [JsonProperty("v")]
        public string v { get; set; }
        [JsonProperty("ttl")]
        public int ttl { get; set; }
        [JsonProperty("provider")]
        public Provider provider { get; set; }
        [JsonProperty("creditsLeft")]
        public int creditsLeft { get; set; }

    }


    public class Match
    {
        [JsonProperty("unique_id")]
        public int unique_id { get; set; }
        [JsonProperty("date")]
        public DateTime date { get; set; }
        [JsonProperty("dateTimeGMT")]
        public DateTime dateTimeGMT { get; set; }
        [JsonProperty("team-1")]
        public string team1 { get; set; }
        [JsonProperty("team-2")]
        public string team2 { get; set; }
        [JsonProperty("type")]
        public string type { get; set; }
        [JsonProperty("squad")]
        public bool squad { get; set; }
        [JsonProperty("matchStarted")]
        public bool matchStarted { get; set; }

    }

    class ApiGetData
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls |
                                      SecurityProtocolType.Tls11 |
                                      SecurityProtocolType.Tls12;
            HttpWebRequest WebReq = (HttpWebRequest)WebRequest.Create(string.Format("https://cricapi.com/api/matches?apikey=xxxxxx"));

            WebReq.Method = "GET";

            HttpWebResponse WebResp = (HttpWebResponse)WebReq.GetResponse();

            Console.WriteLine(WebResp.StatusCode);
            Console.WriteLine(WebResp.Server);

            string jsonString;
            using (Stream stream = WebResp.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
            {
                StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                jsonString = reader.ReadToEnd();
            }
            var valueSet = JsonConvert.DeserializeObject<Root>(jsonString);           

            Console.ReadLine();
        }
    }
}
