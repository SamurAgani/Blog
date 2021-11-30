using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Blog.ViewComponents
{
    public class BlogListDashBoard : ViewComponent
    {
        BlogManeger bm = new BlogManeger(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = Enumerable.Reverse(bm.GetBlogListWithCategory()).Take(5).ToList();
            return View(values);
        }
    }
}

