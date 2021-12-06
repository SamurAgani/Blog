using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{
    public class WriterMessageNatification : ViewComponent
    {
        MessageManager mm = new MessageManager(new EfMessageRepository());
        public IViewComponentResult Invoke()
        {
            string p = "test@gmail.com";
            var values = mm.GetInboxListByWriter(p);
            return View(values);
        }
    }
}

