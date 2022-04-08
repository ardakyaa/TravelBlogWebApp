using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_WebApp.Models.Entities;
namespace TravelTrip_WebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context context = new Context();
        public ActionResult Index()
        {
            var values = context.Blogs.Take(5).ToList();
            return View(values);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var values = context.Blogs.OrderByDescending(t0 => t0.Id).Take(2).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial2()
        {
            var value = context.Blogs.Where(t0 => t0.Id == 1).ToList();
            return PartialView(value);
        }

        public PartialViewResult Partial3()
        {
            var value = context.Blogs.ToList();
            return PartialView(value);
        }

        public PartialViewResult Partial4()
        {
            var value = context.Blogs.Take(2).ToList();
            return PartialView(value);
        }

        public PartialViewResult Partial5()
        {
            var value = context.Blogs.Take(2).OrderByDescending(t0=>t0.Id).ToList();
            return PartialView(value);
        }
    }
}