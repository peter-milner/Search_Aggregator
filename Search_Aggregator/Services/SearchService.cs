using Google.Apis.Customsearch.v1;
using Google.Apis.Services;
using Search_Aggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static Google.Apis.Customsearch.v1.CseResource;

namespace Search_Aggregator.Services
{
    public class SearchService
    {
        public List<SearchResult> getGoogleResults(String query, int itemsPerPage, int page)
        {
            const string apiKey = "AIzaSyCbwi1U_KFwou26QLz1 - K8P5y0pJRwQm30";
            const string searchEngineId = "006347468050510818806:bdoeuah7j4m";
            CustomsearchService service = new CustomsearchService(new BaseClientService.Initializer { ApiKey = apiKey });
            ListRequest request = service.Cse.List(query);
            request.Cx = searchEngineId;
            request.Start = itemsPerPage * page;

            List<SearchResult> results = new List<SearchResult>();
            foreach (var item in request.Execute().Items)
                results.Add(
                    new SearchResult { Title = item.Title, Link = item.Link }
                    );
            return results;
        }
    }
}