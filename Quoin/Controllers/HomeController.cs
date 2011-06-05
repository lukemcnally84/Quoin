using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quoin.Controllers
{
    public partial class HomeController : Controller
    {
        public virtual ActionResult Index()
        {
            ViewBag.Message = "Welcome to Quoin!";

            return View();
        }

        public virtual ActionResult About()
        {
            return View();
        }
    }
}
