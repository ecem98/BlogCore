using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.ViewComponents.Writer
{
    public class WriterMessageNotification : ViewComponent
    {

        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var userMail = User.Identity.Name;
            var writerInfo = writerManager.FetchWriterByMail(userMail);
            var values = message2Manager.GetInboxListByWriter(writerInfo.WriterID);
            
            return View(values);
        }



    }
}
