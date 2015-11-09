using BookStoreServiceApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStoreWebSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookStoreService _service;

        public HomeController(IBookStoreService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            string searchString = null;

            if (this.Request.QueryString.HasKeys())
            {
                if (this.Request.QueryString.Keys[0] == "Search")
                {
                    searchString = this.Request.QueryString.GetValues(0)[0];
                }
            }
            var fetchedAds = _service.GetAds(searchString, null, null);

            return View(fetchedAds);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}