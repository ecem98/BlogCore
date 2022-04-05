using BusinessLayer.Conctrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Areas.Admin.ViewComponents.Statistic

{
    public class Statistic2 : ViewComponent
    {

        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {

            ViewBag.v1 = c.Blogs.OrderByDescending(y => y.BlogID).Select(x=>x.BlogTitle).Take(1).FirstOrDefault();
           
            return View();
        }



    }
}
