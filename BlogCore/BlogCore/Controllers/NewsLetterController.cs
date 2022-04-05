using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());


        public IActionResult SaveCustomer(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            newsLetterManager.Insert(newsLetter);
            return PartialView("Message", newsLetter);
        }


        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            newsLetterManager.Insert(newsLetter);
            return PartialView("Message", newsLetter);
        }



    }
}
