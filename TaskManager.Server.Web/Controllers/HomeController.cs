using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TaskManager.Server.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                ViewBag.UserName = "Hello "+User.Identity.Name;
            }
            else
            {
                ViewBag.UserName = "Hello Guest";
            }
            return View();
        }
    }
}