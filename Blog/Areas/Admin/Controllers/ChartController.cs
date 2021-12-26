using Blog.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Area("Admin")]
public class ChartController : Controller
{ 
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CategoryChart()
    {
        List<CategoryClass> list = new List<CategoryClass>();
        list.Add(new CategoryClass { categoryName = "Teknoloji", categoryCount = 10 });
        list.Add(new CategoryClass { categoryName = "Programming", categoryCount = 14 });
        list.Add(new CategoryClass { categoryName = "Sport", categoryCount = 12 });
        return Json(new { jsonlist = list });
    }
}
