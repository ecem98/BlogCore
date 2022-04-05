using BusinessLayer.Conctrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Controllers
{
    public class DashboardController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            Context  c = new Context();
            ViewBag.v1 = c.Blogs.Count().ToString();
            var mail = User.Identity.Name;
            var userInfo = writerManager.FetchWriterByMail(mail);
            ViewBag.v2 = c.Blogs.Where(x=>x.WriterID==userInfo.WriterID).Count();
            ViewBag.v3 = c.Categories.Count();

            return View();
        }

        



    }
}
