using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class NatificationController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
    }
}

