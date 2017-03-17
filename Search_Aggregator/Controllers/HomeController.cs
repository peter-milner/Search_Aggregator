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
        private readonly IEnumerable <ISearchService> searchServices;
        private const int ITEMS_PER_PAGE = 5;

        public HomeController()
        {
        }
        public HomeController(IEnumerable<ISearchService> services)
        {
            searchServices = services;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Results()
        {
            ViewBag.Error = false;
            foreach (ISearchService service in searchServices)
            {
                try
                {
                    string query = Request.QueryString["query"];
                    int page = Convert.ToInt32(Request.QueryString["page"]);
                    if (page < 1 || query == "") throw new Exception("Invalid query.");

                    ViewBag.SearchResults = service.getResults(query, ITEMS_PER_PAGE, page);
                    ViewBag.Query = query;

                }
                catch (Exception e)
                {
                    ViewBag.Error = true;
                    ViewBag.ErrorMessage = e.Message;
                }
            }
            
            return View();
        }

    }
}