using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blog.Controllers
{
    public class LoginController : Controller
    { 
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer p)
        {
            Context c = new Context();
            var defv = c.Writers.FirstOrDefault(x=>x.WriterMail == p.WriterMail && x.WriterPassword ==p.WriterPassword);
            if(defv != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.WriterMail)
                };
                var userindentity = new ClaimsIdentity(claims,"a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userindentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Dashboard");
            }
            return View();
        }
    }
}

