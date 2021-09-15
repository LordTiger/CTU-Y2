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
    public class LoginController : Controller
    {
        // GET: Login
        AppDbContext db = new AppDbContext();

        public ActionResult Login(Register login)
        {
            if (ModelState.IsValid)
            {
                var user = (from userlist in db.Register
                            where userlist.Username == login.Username && userlist.Password == login.Password
                            select new
                            {
                                userlist.id,
                                userlist.Username
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["UserName"] = user.FirstOrDefault().Username;
                    Session["UserID"] = user.FirstOrDefault().id;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(login);
        }

    }
}