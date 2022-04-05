using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {

        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        
        public IViewComponentResult Invoke()
        {
            //var writerValues = writerManager.GetWriterById(1);

            //return View(writerValues);
            var userMail = User.Identity.Name;
            var writerInfo = writerManager.FetchWriterByMail(userMail);
            var writerValues = writerManager.GetById(writerInfo.WriterID);
            return View (writerValues);
        }



    }
}
