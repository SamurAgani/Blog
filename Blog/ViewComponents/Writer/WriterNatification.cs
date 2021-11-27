using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{
    public class WriterNatification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

