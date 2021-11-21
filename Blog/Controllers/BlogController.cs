using Blog.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class BlogController : Controller
    {
        BlogManeger bm = new BlogManeger(new EfBlogRepository());
        public IActionResult Index()
        {
            List<EntityLayer.Concrete.Blog> blogs = bm.GetBlogListWithCategory();
          
            return View(blogs);
        }
        public IActionResult BlogReadAll(int Id)
        {
            ViewBag.Id = Id;
            var values = bm.GetBlogById(Id);
            return View(values);
        }
    }
}

