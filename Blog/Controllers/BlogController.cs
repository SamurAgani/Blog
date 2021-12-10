using Blog.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using EntityLayer.Concrete;
using System.Threading.Tasks;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.Rendering;
using DataAccessLayer.Concrete;

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

        public IActionResult BlogListByWriter()
        {
            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values=bm.GetListWithCategoryByWriterBm(writerId);
            return View(values);
        }

        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;

            return View();
        }
        [HttpPost]
        public IActionResult BlogAdd(EntityLayer.Concrete.Blog p)
        {

            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            BlogValidator wv = new BlogValidator();

            ValidationResult results = wv.Validate(p);

            if (results.IsValid)
            {
                p.BlogStatus = true;
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.WriterID = writerId;
                bm.Add(p);
                return RedirectToAction("BlogListByWriter", "Blog");
            }
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View();
        }

        public IActionResult DeleteBlog(int Id)
        {
            var bv = bm.GetById(Id);
            bm.Delete(bv);
            return RedirectToAction("BlogListByWriter");
        }

        public IActionResult EditBlog(int Id)
        {
            CategoryManager cm = new CategoryManager(new EfCategoryRepository());
            List<SelectListItem> categoryValues = (from x in cm.GetList()
                                                   select new SelectListItem
                                                   {
                                                       Text = x.CategoryName,
                                                       Value = x.CategoryID.ToString()
                                                   }).ToList();
            ViewBag.cv = categoryValues;
            var blog = bm.GetById(Id);
            return View(blog);
        }

        [HttpPost]
        public IActionResult EditBlog(EntityLayer.Concrete.Blog p)
        {

            Context c = new Context();
            var usermail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            p.WriterID = writerId;
            bm.Update(p);
            return RedirectToAction("BlogListByWriter");
        }
    }

}

