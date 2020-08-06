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
        // GET: Subject
        public ActionResult Index()
        {
            return View();
        }
    }
}