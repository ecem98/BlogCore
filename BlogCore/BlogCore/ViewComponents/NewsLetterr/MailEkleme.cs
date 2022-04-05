using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.ViewComponents.Yorum
{
    public class MailEkleme:ViewComponent
    {
        NewsLetterManager newsLetterManager = new NewsLetterManager(new EfNewsLetterRepository());

        public IViewComponentResult Invoke()
        {
            NewsLetter newsLetter = new NewsLetter();
            return View(newsLetter);
        }

      



    }
}
