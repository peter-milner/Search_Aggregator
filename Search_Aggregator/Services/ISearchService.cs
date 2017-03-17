using Search_Aggregator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_Aggregator.Services
{
    public interface ISearchService
    {
        List<SearchResult> getResults(String query, int itemsPerPage, int page);
    }
}
