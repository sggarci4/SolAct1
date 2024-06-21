using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAct1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Vista1");
        }
        public ActionResult IrAVista2()
        {
            return View("Vista2");
        }
        public ActionResult IrAVista3()
        {
            return View("Vista3");
        }
    }
}