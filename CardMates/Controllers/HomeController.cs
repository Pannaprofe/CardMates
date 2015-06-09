using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using CardMates.Models;

namespace CardMates.Controllers
{
    public class HomeController : Controller
    {
        NewsContext db = new NewsContext();

        public ActionResult Index()
        {
            ViewBag.Message = "Main Page";
            var currentUser = db.UserProfiles.FirstOrDefault(user => user.UserName == User.Identity.Name);
            if (currentUser != null && currentUser.IsAdmin)
            {
                ViewBag.IsAdmin = true;
            }
            else if (currentUser!=null)
            {
                ViewBag.IsAdmin = false;
            }
            else
            {
                ViewBag.IsAdmin = null;
            }

            return View("Index",db.News);
        }

        public ActionResult Forum()
        {
            ViewBag.Message = "Your Forum page.";

            return View("Forum");
        }
        public ActionResult News(int id)
        {
            ViewBag.ID = id;
            List<NewOne> allNews = db.News.AsEnumerable().ToList();
            var otherNews = new List<NewOne> {allNews[0], allNews[1]};
            ViewBag.OtherNews = otherNews;
            ViewBag.db = db;
            NewOne news = db.News.Find(id);
            CurrentInformation.currentNew = news;
            return View("News",news);
        }

        public ActionResult AddComment(string comment)
        {
            CommentContext com = new CommentContext();
            com.body = comment;
            com.comment_date = DateTime.Now;
            com.author = User.Identity.Name;
            com.news_id = CurrentInformation.currentNew.news_ID;

            db.Comments.Add(com);
            db.SaveChanges();
            return PartialView(com);
        }

        [HttpGet]
        public ActionResult AddNews()
        {
            ViewBag.Title = "Title";
            return View("AddNews");
        }

        [HttpPost]
        public ActionResult AddNews(NewOne aNew)
        {
            aNew.news_date = DateTime.Now;
            db.News.Add(aNew);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult DeleteNews(int id)
        {
            NewOne aNew = db.News.Find(id);
            db.News.Remove(aNew);
            foreach (CommentContext comment in db.Comments)
            {
                if (comment.news_id == id)
                {
                    db.Comments.Remove(comment);
                }
            }

            db.SaveChanges();
            var news = db.News.OrderByDescending(anew => anew.news_date);
            return View("Index", news);
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
