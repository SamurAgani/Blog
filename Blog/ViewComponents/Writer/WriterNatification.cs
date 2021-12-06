using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{
    public class WriterNatification : ViewComponent
    {
        NatificationManager nm = new NatificationManager(new EfNatificationRrepository());

        public IViewComponentResult Invoke()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}

