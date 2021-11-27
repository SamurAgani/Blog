using Microsoft.AspNetCore.Mvc;
namespace Blog.ViewComponents
{
    public class WriterMessageNatification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

