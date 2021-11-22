using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManeger nm = new NewsLetterManeger(new EfNewsLetterRepository());
        public PartialViewResult SubscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            nm.AddNewsletter(newsLetter);
            return PartialView();
        }
    }
}

