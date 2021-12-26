using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Blog.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class BlogController : Controller
    {
        public IActionResult ExportStaticExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog List");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";
                worksheet.Cell(1, 3).Value = "Blog Id";
                worksheet.Cell(1, 4).Value = "Blog Id";
                int blogrowcount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheet.Cell(blogrowcount, 1).Value = item.Id;
                    worksheet.Cell(blogrowcount, 2).Value = item.BlogName;
                    blogrowcount++;
                }
                using var stream = new MemoryStream();
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.open.xmlformat-afficedocument.spreadsheetml.sheet", "Work1.xlsx");
            }
        }
        public List<BlogModel> GetBlogList()
        {
            List<BlogModel> a = new List<BlogModel>()
            {
                new BlogModel{Id = 1,BlogName = "C# dedadasdee"},
                new BlogModel{Id = 2,BlogName = "Tesla asdasd"},
                new BlogModel{Id = 3,BlogName = "Amazonasdasd"},
                new BlogModel{Id = 4,BlogName = "asdasdadasd"},
                new BlogModel{Id = 5,BlogName = "alalalalalala"},
            };
            return a;

        }
        public IActionResult BlogListExcel()
        {
            return View();
        }
        public IActionResult ExportDinamicExcelBlogList()
        {

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog List");
                worksheet.Cell(1, 1).Value = "Blog Id";
                worksheet.Cell(1, 2).Value = "Blog Name";
                int blogrowcount = 2;
                foreach (var item in BlogTitleList())
                {
                    worksheet.Cell(blogrowcount, 1).Value = item.Id;
                    worksheet.Cell(blogrowcount, 2).Value = item.BlogName;
                    blogrowcount++;
                }
                using var stream = new MemoryStream();
                workbook.SaveAs(stream);
                var content = stream.ToArray();
                return File(content, "application/vnd.open.xmlformat-afficedocument.spreadsheetml.sheet", "Work1.xlsx");
            }
        }
        public List<BlogModel2> BlogTitleList()
        {
            List<BlogModel2> bm = new List<BlogModel2>();
            using var c = new Context();
            bm = c.Blogs.Select(x => new BlogModel2 {
                Id = x.BlogID,
                BlogName = x.BlogTitle
            }).ToList();
            return bm;
        }
        public IActionResult BlogTitleListExcel()
        {
            return View();
        }
    }
}
