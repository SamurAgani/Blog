using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Blog.ViewComponents
{
    public class WriterAboutDashboard : ViewComponent
    {
        Writermaneger wv = new Writermaneger(new EfWriterRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var usermail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
            var values = wv.GetWriterById(writerId);
            return View(values);
        }

    }
}

