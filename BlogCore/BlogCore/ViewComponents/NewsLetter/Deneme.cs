using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.ViewComponents.Comment
{
    public class Deneme : ViewComponent
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

        [HttpPost]
        public IViewComponentResult  Invoke (NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            newsLetterManager.Insert(newsLetter);
            return View();
        }



    }
}
