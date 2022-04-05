using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Controllers
{
    public class MessageController : Controller
    {

        Message2Manager message2Manager = new Message2Manager(new EfMessage2Repository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [AllowAnonymous]
        public IActionResult InBox()
        {
            var userMail = User.Identity.Name;
            var userInfo = writerManager.FetchWriterByMail(userMail);

            var liste=message2Manager.GetInboxListByWriter(userInfo.WriterID);
          
            return View(liste);
        }

        [AllowAnonymous]
        public IActionResult ShowMessageDetail(int id)
        {
            var massageDatail = message2Manager.GetDetailWithWriter(id);

            return View(massageDatail);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult CreateNewMessage( )
        {
            
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateNewMessage(Message2 message2)
        {
            message2Manager.TAdd(message2);

            return RedirectToAction("Index", "Dashboard");
        }
    }
}
