using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagniCollegium.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Magni Collegium";
            return View();
        }

        [HttpGet]
        public JsonResult GetHomepageData()
        {
            return new JsonResult();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Welcome to the MagniCollegium web page, here you can manage our Courses, Subjects, Teachers, Students and Grades!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tomás Grilo";

            return View();
        }
    }
}