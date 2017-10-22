using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        public ActionResult Search(string name = "Thai")
        {
            var message = Server.HtmlEncode(name);
            return Content("Cuisine::Search(" + name + ")");
            //return View();
        }
    }
}