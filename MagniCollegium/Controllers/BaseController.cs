using MagniCollegium.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagniCollegium.Controllers
{
    /// <summary>
    /// T is the model parameter
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="P"></typeparam>
    public abstract class BaseController<T> : Controller
        where T : class, new()
    {
        protected MagniCollegiumDBContext context;
        public BaseController()
        {
            context = new MagniCollegiumDBContext();
        }

        [HttpPost]
        public JsonResult Create(T model)
        {
            if(model != null)
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        [HttpGet]
        public JsonResult ReadAll()
        {
            return Json(context.Set<T>().ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult Read(int key)
        {
            return Json(context.Set<T>().Find(key), JsonRequestBehavior.AllowGet);
        }

        [HttpPut]
        public JsonResult Update(T model, int key)
        {
            if(model == null)
            {
                return Json(new { success = false });
            }

            var currentModel = context.Set<T>().Find(key);

            if(currentModel != null)
            {
                context.Entry(currentModel).CurrentValues.SetValues(model);
                context.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

        [HttpDelete]
        public JsonResult Delete(int key)
        {
            var modelToDelete = context.Set<T>().Find(key);

            if (modelToDelete != null)
            {
                context.Set<T>().Remove(modelToDelete);
                context.SaveChanges();
                return Json(new { success = true });
            }

            return Json(new { success = false });
        }

    }
}