using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.ViewComponents.Blog
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());
        
        public IViewComponentResult Invoke(int id)
        {
            var liste=commentManager.GetListAll(id);
            return View(liste);
        }



    }
}
