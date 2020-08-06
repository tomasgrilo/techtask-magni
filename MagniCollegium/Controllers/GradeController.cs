using MagniCollegium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagniCollegium.Controllers
{
    public class GradeController : BaseController<Grade>
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetAverageGrade()
        {
            var grades = this.context.Grades.ToList();
            double totalGrades = grades.Average(x => x.Score);
            return Json(totalGrades, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetAverageGradePerUser()
        {
            var grades = this.context.Grades.ToList();
            var rates = grades
               .GroupBy(g => g.Student.Id, r => r.Score)
               .Select(g => new
               {
                   UserId = g.Key,
                   Rating = g.Average()
               });
            return Json(rates, JsonRequestBehavior.AllowGet);
        }


    }
}