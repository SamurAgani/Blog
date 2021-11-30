using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{
    public class CategoryListDashBoard : ViewComponent
    {
        CategoryManager CM = new CategoryManager(new EfCategoryRepository());
        public IViewComponentResult Invoke()
        {
            var values = CM.GetList();
            return View(values);
        }
    }
}

