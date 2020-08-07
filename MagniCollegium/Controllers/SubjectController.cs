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

            var currentSubject = context.Subjects.Find(key);
            if(currentSubject != null)
            {
                currentSubject.Name = model.Name;

                //this way it prevents creating another teacher, since we are referecing the existing one
                var newTeacher = context.Teachers.Find(model.Teacher.Id);
                if(newTeacher.Id != currentSubject.Teacher.Id)
                {
                    currentSubject.Teacher = newTeacher;
                }

                context.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        public override JsonResult Create(Subject model)
        {
            //Defining foreign key teacher otherwise model creates a new one on EF
            var teacher = context.Teachers.Find(model.Teacher.Id);
            model.Teacher = teacher;

            return base.Create(model);
        }



    }
}