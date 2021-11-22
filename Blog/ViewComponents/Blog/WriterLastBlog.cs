using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManeger bm = new BlogManeger(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListByWriter(1);
            return View(values);
        }
    }
}

