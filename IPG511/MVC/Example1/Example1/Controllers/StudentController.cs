using Example1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Example1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        //[HttpGet] // Only Viewing

        private stDataContext studData = new stDataContext();
        public ActionResult Index()
        {
            
            return View();
        }
    }
}