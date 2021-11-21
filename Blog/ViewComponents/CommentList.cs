using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.ViewComponents
{
    public partial class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Name = "samur"
                },
                  new UserComment
                {
                    ID = 2,
                    Name = "lamur"
                },  new UserComment
                {
                    ID = 1,
                    Name = "dataur"
                }
            };
            return View(commentvalues);
        }
    }
}

