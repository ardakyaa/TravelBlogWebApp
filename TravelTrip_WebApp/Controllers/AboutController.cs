using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_WebApp.Models.Entities;

namespace TravelTrip_WebApp.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Abouts.ToList();
            return View(values);
        }
    }
}