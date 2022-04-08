using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_WebApp.Models.Entities;

namespace TravelTrip_WebApp.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var values = context.Blogs.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            return View("GetBlog", blog);
        }

        public ActionResult UpdateBlog(Blog b)
        {
            var blog = context.Blogs.Find(b.Id);
            blog.BlogContent = b.BlogContent;
            blog.Header = b.Header;
            blog.BlogImage = b.BlogImage;
            blog.Date = b.Date;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult CommentList()
        {
            var commentList = context.Comments.ToList();
            return View(commentList);
        }

        public ActionResult DeleteComment(int id)
        {
            var comment = context.Comments.Find(id);
            context.Comments.Remove(comment);
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }

        public ActionResult GetComment(int id)
        {
            var comment = context.Comments.Find(id);
            return View("GetComment", comment);
        }

        public ActionResult UpdateComment(Comment c)
        {
            var comment = context.Comments.Find(c.Id);
            comment.UserName = c.UserName;
            comment.Email = c.Email;
            comment.UserComment = c.UserComment;
            context.SaveChanges();
            return RedirectToAction("CommentList");
        }
    }
}