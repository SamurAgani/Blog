using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class NatificationController : Controller
    {
        NatificationManager nm = new NatificationManager(new EfNatificationRrepository());
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult AllNatifation()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}

