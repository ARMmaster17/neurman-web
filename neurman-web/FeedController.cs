﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace neurman_web
{
    public class FeedController : Controller
    {
        // GET: Feed
        public ActionResult Index()
        {
            return View();
        }
    }
}