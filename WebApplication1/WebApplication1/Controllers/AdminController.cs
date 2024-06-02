using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.custommodel;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        Model_hiringEntities db = new Model_hiringEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

    }
}