using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.ViewComponents.About
{
    public class GetLastTreeBlog : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        
        
        public IViewComponentResult Invoke()
        {
            var list = blogManager.GetLastTreeBlogForAbout();
           
            return View(list);
        }



    }
}
