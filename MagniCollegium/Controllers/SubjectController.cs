using MagniCollegium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagniCollegium.Controllers
{
    public class SubjectController : BaseController<Subject>
    {

        public ActionResult Index()
        {
            return View();
        }

        public override JsonResult Delete(int key)
        {
            //remove grades first which is a child dependent of Subjext
            var grades = context.Grades.Where(x => x.Subject.Id == key);
            context.Grades.RemoveRange(grades);
            context.SaveChanges();

            return base.Delete(key);
        }

        public override JsonResult Update(Subject model, int key)
        {


            return base.Update(model, key);
        }


    }
}