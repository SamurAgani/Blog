using System;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{    
    public class CommentListByBlog : ViewComponent
    {
        CommentManeger cm = new CommentManeger(new EfCommentRepository());
        public IViewComponentResult Invoke(int Id)
        {
            var values = cm.GetList(Id);
            return View(values);
        }

    }    
}

