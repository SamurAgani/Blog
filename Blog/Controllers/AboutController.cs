using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class AboutController : Controller
    {
        AboutManeger abm = new AboutManeger(new EfAboutRepository());
        public IActionResult Invoke()
        {
            return View();
        }
        public PartialViewResult SocialMediaAbout()
        {
            var values = abm.GetList();
            return PartialView(values);
        }
    }
}

