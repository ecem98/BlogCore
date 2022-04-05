using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Controllers
{
    public class AboutController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        AboutManager aboutController = new AboutManager(new EfAboutRepository());
        public IActionResult Index()
        {
            var list = aboutController.GetList();
          
            return View(list);
        }


        public PartialViewResult SocialMediaAbout()
        {
            return PartialView();

        }


        public PartialViewResult GetLastTreeBlog()
        {
            var blogs = blogManager.GetLastTreeBlogForAbout();
            return PartialView(blogs);

        }


    }
}
