using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTrip_WebApp.Models.Entities;
namespace TravelTrip_WebApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        BlogComment blogComment = new BlogComment();
        public ActionResult Index()
        {
            //var blogs = context.Blogs.ToList();
            blogComment.Value1 = context.Blogs.ToList();
            blogComment.Value3 = context.Blogs.OrderByDescending(t0=>t0.Id).Take(2).ToList();
            blogComment.Value2 = context.Comments.OrderByDescending(t0 => t0.Id).Take(2).ToList();
            return View(blogComment);
        }
        
        public ActionResult BlogDetail(int id)
        {
            //var findBlog = context.Blogs.Where(t0 => t0.Id == id).ToList();
            blogComment.Value1 = context.Blogs.Where(t0 => t0.Id == id).ToList();
            blogComment.Value2 = context.Comments.Where(t0 => t0.BlogId == id).ToList();
            return View(blogComment);
        }

        [HttpGet]
        public PartialViewResult CommentSave(int id)
        {
            ViewBag.value = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult CommentSave(Comment comment)
        {
            context.Comments.Add(comment);
            context.SaveChanges();
            return PartialView();
        }
    }
}