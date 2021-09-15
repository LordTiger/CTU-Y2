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
    public class RegisterController : Controller
    {
        // GET: Register
        AppDbContext db = new AppDbContext();
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Register register)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Register.Add(register);
                    db.SaveChanges();
                     return RedirectToAction("Login", "Login");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(ex.Message, "");
            }
            return View(register);
        }
    }
}