//Brandon de Bruyn 6854

using FA.Data;
using FA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FA.Controllers
{
    public class HomeController : Controller
    {


        AppDbContext db = new AppDbContext();
        [HttpGet]
        public ActionResult Index()
        {
            var home = from e in db.Home
                           select e;


            return View(home);  
        }

        [HttpGet]
        public ActionResult Create()
        { return View(); }

        [HttpPost]
        public ActionResult Create(Home home)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Home.Add(home);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Message, "");
            }
            return View(home);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            // Lamba Expression
            var home = db.Home.Find(id);
            return View(home);
        }

        public ActionResult Edit(int id, FormCollection collection)
        {
            var home = db.Home.Find(id);

            if (ModelState.IsValid)
            {
                if (TryUpdateModel(home))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("Database Connection falied: Update", "");
            }
            return View(home);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            // Lamba Expression
            var home = db.Home.Find(id);
            return View(home);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var home = db.Home.Find(id);
            return View(home);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var home = db.Home.Find(id);
                db.Home.Remove(home);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception Ex)
            {
                ModelState.AddModelError(Ex.Message, " ");

            }
            return View();
        }
    }
}