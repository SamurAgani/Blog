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

            var values = abm.GetList();
            return View(values);
        }
        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();
        }
    }
}

