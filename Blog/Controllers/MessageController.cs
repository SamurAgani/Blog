using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [AllowAnonymous]
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IActionResult InBox()
        {
            int id = 1;
            var values = mm.GetInboxListByWriter(1);
            return View(values);
        }
        public IActionResult MessageDetails(int Id)
        {            
            var message = mm.GetById(3);
            return View(message);
        }
    }
}

