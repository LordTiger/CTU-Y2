using Practical_1_May_12.Data_Folder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical_1_May_12.Controllers
{
    public class ShelfsController : Controller
    {
        // GET: Shelfs
        AppDbContext appDb = new AppDbContext();
        public ActionResult Index()
        {
            var shelfs = from e in appDb.Shelfs select e;
            return View(shelfs);
        }
    }
}