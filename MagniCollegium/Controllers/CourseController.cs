﻿using MagniCollegium.Data;
using MagniCollegium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagniCollegium.Controllers
{
    public class CourseController : BaseController<Course>
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}