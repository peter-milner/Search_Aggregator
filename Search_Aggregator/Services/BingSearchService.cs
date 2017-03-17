using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Search_Aggregator.Models;
using System.Net;
using Newtonsoft.Json;

namespace Search_Aggregator.Services
{
    public class BingSearchService : ISearchService
    {
        public List<SearchResult> getResults(string query, int itemsPerPage, int page)
        {
            const string subscriptionKey = "2d8c7a712b2b435e9c2d976e98a5576b";
            string requestURL = @"https://api.cognitive.microsoft.com/bing/v5.0/search?q="+query+"&count=" + itemsPerPage + "&offset=" + page*itemsPerPage;
            string json = "";
            using (var client = new WebClient())
            {
                //client.Headers[HttpRequestHeader.AcceptLanguage] = "en-US";
                client.Headers["Ocp-Apim-Subscription-Key"] = subscriptionKey;
                json = client.DownloadString(requestURL);
            }
            var jsonParsed = JsonConvert.DeserializeObject<dynamic>(json);

            List<SearchResult> results = new List<SearchResult>();
            foreach (var item in jsonParsed.webPages.value)
                results.Add(
                    new SearchResult { Title = item.name, Link = item.url }
                    );
            return results;
 
        }
    }
}