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
            List<EntityLayer.Concrete.Blog> blogs = new List<EntityLayer.Concrete.Blog>();
            blogs.Add(new EntityLayer.Concrete.Blog() { BlogTitle="C# ile asinxron", BlogImage = "/web/images/7.jpg",  BlogCreateDate = DateTime.Now, BlogStatus = true, CategoryID = 4 });
            blogs.Add(new EntityLayer.Concrete.Blog() { BlogTitle="Phyton ile asinxron", BlogImage = "/web/images/7.jpg",  BlogCreateDate = DateTime.Now, BlogStatus = true, CategoryID = 1 });
            blogs.Add(new EntityLayer.Concrete.Blog() { BlogTitle="In to the wild", BlogImage = "/web/images/7.jpg",  BlogCreateDate = DateTime.Now, BlogStatus = true, CategoryID = 1 });
            blogs.Add(new EntityLayer.Concrete.Blog() { BlogTitle="Wild rift", BlogImage = "/web/images/7.jpg",  BlogCreateDate = DateTime.Now, BlogStatus = true, CategoryID = 4 });
            //var values = bm.GetList(); data bazaya elave edennen sora ustu silif buynan davam edirsen
            return View(blogs);
        }
    }
}

