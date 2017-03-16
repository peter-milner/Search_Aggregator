using Search_Aggregator.Models;
using Search_Aggregator.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Search_Aggregator.Controllers
{
    public class HomeController : Controller
    {
        private SearchService searchService = new SearchService();
        public ActionResult Index()
        {
            try
            {
                ViewBag.SearchResults = searchService.getGoogleResults("hi", 5, 1);
            }
            catch
            {
                ViewBag.SearchResults = "Error";
            }
            return View();
        }

    }
}