using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{
    public class WriterAboutDashboard : ViewComponent
    {
        Writermaneger wv = new Writermaneger(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var values = wv.GetWriterById(1);
            return View(values);
        }

    }
}

