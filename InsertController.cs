﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class InsertController : Controller
    {
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }
    }
}