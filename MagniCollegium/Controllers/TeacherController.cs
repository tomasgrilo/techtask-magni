﻿using MagniCollegium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagniCollegium.Controllers
{
    public class TeacherController : BaseController<Teacher>
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }
    }
}