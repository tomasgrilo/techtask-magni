using MagniCollegium.Models;
using MagniCollegium.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagniCollegium.Controllers
{
    public class CourseController : Controller
    {
        [HttpGet]
        public JsonResult GetCourses()
        {
            var persistence = new CoursePersistence();

            return Json(persistence.GetCourses(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult InsertCourse(Course course)
        {
            var persistence = new CoursePersistence();

            if(course != null)
            {
                persistence.InsertCourse(course);
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }
    }
}