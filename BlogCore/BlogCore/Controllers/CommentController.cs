using BusinessLayer.Conctrete;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;
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
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager(new EfCommentRepository());

        public IActionResult Index()
        {
          
            return View();
        }


        public IActionResult SaveComment(Comment comment)
        {
                comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                comment.CommentStatus = true;
                comment.BlogID = 7;
                commentManager.Insert(comment);
            ViewBag.id = comment.BlogID;
            return PartialView("Message");
            //return RedirectToAction("BlogReadAll","Blog", new { id = comment.BlogID });











        }

    }
}
