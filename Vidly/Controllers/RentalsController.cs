using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    [RoutePrefix("Rentals")]
    public class RentalsController : Controller
    {
        // GET: Rentals
        [Route]
        public ActionResult Index()
        {
            return View("ActiveList");
        }

        // GET: Rentals/All
        [Route("All")]
        public ActionResult All()
        {
            return View("FullList");
        }

        // GET: Rentals/New
        [Route("new")]
        public ActionResult New()
        {
            return View();
        }
    }
}