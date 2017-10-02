using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace yruiysApplication.Controllers
{
    public class HandlerController : Controller
    {
        // GET: Handler
        public ActionResult Index()
        {
            return View();
        }
        public string Test()
        {
            return "Hello world";
        }
    }
}