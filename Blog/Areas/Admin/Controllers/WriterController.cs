using Blog.Models;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Blog.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var JsonWriters = JsonConvert.SerializeObject(writers);
            return Json(JsonWriters);
        }

        public IActionResult GetWriterById(int Id)
        {
            var writer = writers.FirstOrDefault(x => x.Id == Id);
            var  JsonWriters = JsonConvert.SerializeObject(writer);
            return Json(JsonWriters);
        }

        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
            {
                 Id =1,
                 Name="Samur"
            },
             new WriterClass
            {
                 Id =2,
                 Name="Murad"
            },
              new WriterClass
            {
                 Id =3,
                 Name="Ekber"
            }
        };
    }
}