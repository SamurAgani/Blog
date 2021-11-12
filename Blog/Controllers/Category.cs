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
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}