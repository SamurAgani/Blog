using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Blog.ViewComponents
{
    public class CategoryList : ViewComponent
    {
        CategoryManager CM = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = CM.GetList();
            return View(values);
        }
    }    
}

