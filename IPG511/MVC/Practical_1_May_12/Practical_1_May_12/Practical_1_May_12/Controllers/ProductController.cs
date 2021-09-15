using Practical_1_May_12.Data_Folder;
using Practical_1_May_12.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Practical_1_May_12.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        AppDbContext appData = new AppDbContext();
        [HttpGet]
        public ActionResult List()
        {
            var products = from e in appData.Products
                           select e;
            return View(products);
        }

        [HttpGet]
        public ActionResult Create()
        { return View(); }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    appData.Products.Add(product);
                    appData.SaveChanges();
                    return RedirectToAction("List");
                }
            } catch (Exception ex)
            {
                ModelState.AddModelError(ex.Message, "");
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            // Lamba Expression
            var product = appData.Products.Find(id);
            return View(product);
        }
        public ActionResult Edit(int id, FormCollection collection)
        {
            var product = appData.Products.Find(id);

            if (ModelState.IsValid)
            {
                if (TryUpdateModel(product))
                {
                    appData.SaveChanges();
                    return RedirectToAction("List");
                }
                else
                    ModelState.AddModelError("Database Connection falied: Update", "");
            }
            return View(product);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            // Lamba Expression
            var product = appData.Products.Find(id);
            return View(product);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var product = appData.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var product = appData.Products.Find(id);
                appData.Products.Remove(product);
                appData.SaveChanges();
                return RedirectToAction("List");
            }
            catch(Exception Ex)
            {
                ModelState.AddModelError(Ex.Message, " ");

            }
            return View();
        }
    }


}