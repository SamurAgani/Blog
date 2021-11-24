using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Blog.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact p)
        {
            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.ContentStatus  = true;
            cm.ContactAdd(p);
            return RedirectToAction("Index","Blog");
        }
    }
}

