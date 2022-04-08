using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TravelTrip_WebApp.Models.Entities;

namespace TravelTrip_WebApp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            var userInformation = context.Admins.FirstOrDefault(t0 => t0.UserName == admin.UserName && t0.Password == admin.Password);
            if (userInformation!=null)
            {
                FormsAuthentication.SetAuthCookie(userInformation.UserName, false);
                Session["UserName"] = userInformation.UserName.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login");
        }
    }
}