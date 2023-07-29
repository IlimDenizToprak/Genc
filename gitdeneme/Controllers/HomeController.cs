using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gitdeneme.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Teams()
        {
            return View();
        }
        public ActionResult Teams_Detail()
        {
            return View();
        }
        public ActionResult Activities()
        {
            return View();
        }
        public ActionResult Activity_Detail()
        {
            return View();
        }

    }
}