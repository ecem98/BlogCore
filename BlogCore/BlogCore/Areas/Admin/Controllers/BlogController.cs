using BlogCore.Areas.Admin.Models;
using BusinessLayer.Conctrete;
using ClosedXML.Excel;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {


        public IActionResult ExportStaticExelList()
        {
            using (var workbook =new XLWorkbook()) {
                var worksheed = workbook.Worksheets.Add("Blog Listesi");
                worksheed.Cell(1, 1).Value = "Blog ID";
                worksheed.Cell(1, 2).Value = "Blog Adı";
                int BlogRowCount = 2;
                foreach (var item in GetBlogList())
                {
                    worksheed.Cell(BlogRowCount, 1).Value = item.ID;
                    worksheed.Cell(BlogRowCount, 2).Value = item.BlogName;
                    BlogRowCount++;
                }
                using(var stream =new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet","Çalışma1.xlsx");
                }
            }
          
            //return View();
        }
       public List<BlogModel> GetBlogList()
        {
            List<BlogModel> bm = new List<BlogModel>
            {
                new BlogModel{ ID=1, BlogName="C# ile programlamaya giriş."},
                new BlogModel{ ID=2, BlogName="2020 Olimpiyatları."},
                 new BlogModel{ ID=3, BlogName="Tesla firması araçları" }
            };
            return bm;
        }


        public IActionResult BlogListExel()
        {
            return View();
        }

    }
}
