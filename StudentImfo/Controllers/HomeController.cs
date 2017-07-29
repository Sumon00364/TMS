using StudentImfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentImfo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(StudentInformation student)
        {
            return View();
        }
    }
}