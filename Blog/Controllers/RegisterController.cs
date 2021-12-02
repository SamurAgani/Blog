using Blog.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class RegisterController : Controller
    {
       
        Writermaneger wm = new Writermaneger(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WritersValidations wv = new WritersValidations();
            
            ValidationResult results = wv.Validate(p);
            
            if (results.IsValid)
            {
                p.WriterStatus = "Active";
                p.WriterAbout = "Test";
                wm.Add(p);
                return RedirectToAction("Index", "Blog");
            }
            foreach (var item in results.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
            return View(); 
        }
    }
}

