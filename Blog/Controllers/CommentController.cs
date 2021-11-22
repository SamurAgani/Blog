using Blog.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class CommentController : Controller
    {
        CommentManeger cm = new CommentManeger(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialAddComment(int Id)
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogID = 2;
            cm.AddComment(comment);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int Id)
        {
            var values = cm.GetList(2);
            return PartialView(values);
        }
    }
}


