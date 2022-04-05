using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        
        
        public IViewComponentResult Invoke(int id)
        {
            //var list = blogManager.GetTreeBlogByWriter(2);
            //var id = 2;
            var list = blogManager.GetTreeBlogByWriter(id);

            ViewBag.id = id;
            return View(list);
        }



    }
}
