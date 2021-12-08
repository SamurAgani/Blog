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
            int id = 1;
            var values = mm.GetInboxListByWriter(id);
            return View(values);
        }
    }
}

