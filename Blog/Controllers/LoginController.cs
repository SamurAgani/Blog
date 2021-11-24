using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class LoginController : Controller
    { 
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
    }
}

