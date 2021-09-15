using Summative.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Summative.Controllers
{
    [Authorize(Roles = "Author")]
    public class PaperController : Controller
    {

        ApplicationDbContext applicationDb = new ApplicationDbContext();
        // GET: Paper
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View(applicationDb.Papers.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult MyPapers()
        {
            var papers = applicationDb.Papers.Where(s => s.AuthorName.ToLower()
            == User.Identity.Name.ToLower());
            var topics = applicationDb.Topics.ToList();

            return View(new PaperViewModel { 
                Papers = papers,
                Topics = topics
            });
        }

        [HttpPost]
        public ActionResult Create(Paper paper)
        {
            if(ModelState.IsValid)
            {
                paper.AuthorName = User.Identity.Name;
                paper.SubmissionDate = DateTime.UtcNow;
                paper.TopicId = int.Parse(paper.sTopicId);

                applicationDb.Papers.Add(paper);
                applicationDb.SaveChanges();
                return RedirectToAction("MyPapers");
            }
            return View(paper);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var home = applicationDb.Papers.Find(id);
            return View(home);
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                var delpaper = applicationDb.Papers.Find(id);
                applicationDb.Papers.Remove(delpaper);
                applicationDb.SaveChanges();
                return RedirectToAction("MyPapers");
            }
            catch (Exception Ex)
            {
                ModelState.AddModelError(Ex.Message, " ");

            }
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int id)
        {
            // Lamba Expression
            var epaper = applicationDb.Papers.Find(id);
            return View(epaper);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var epaper = applicationDb.Papers.Find(id);

            if (ModelState.IsValid)
            {
                if (TryUpdateModel(epaper))
                {
                    applicationDb.SaveChanges();
                    return RedirectToAction("MyPapers");
                }
                else
                    ModelState.AddModelError("Database Connection falied: Update", "");
            }
            return View(epaper);
        }
    }
}