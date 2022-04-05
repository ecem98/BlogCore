using BlogCore.Models;
using BusinessLayer.Conctrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Controllers
{
    public class WriterController : Controller
    {

        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        [Authorize]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.userMail = userMail;
            Context c = new Context();
            var userName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.userName = userName;
            return View();
        }

        [AllowAnonymous]
        public IActionResult Test()
        {

            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile()
        {
            var mail = User.Identity.Name;
            var userInfo = writerManager.FetchWriterByMail(mail);
            var writerValues = writerManager.GetById(userInfo.WriterID);
            return View(writerValues);
            
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer writer)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult results = validationRules.Validate(writer);
            if (results.IsValid)
            {
                writerManager.TUpdate(writer);
                return RedirectToAction("Index", "Dashboard");
            }

            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }



        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterProfileAdd()
        {
            
            return View();

        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterProfileAdd(AddProfileImage addProfileImage)
        {
            Writer w = new Writer();
            if (addProfileImage.WriterImage != null)
            {
                var extension = Path.GetExtension(addProfileImage.WriterImage.FileName);
                var newimagename = Guid.NewGuid()+extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/",newimagename);
                var stream = new FileStream(location,FileMode.Create);
                addProfileImage.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;

            }
            w.WriterMail = addProfileImage.WriterMail;
            w.WriterName = addProfileImage.WriterName;
            w.WriterPassword = addProfileImage.WriterPassword;
            w.WriterPasswordConfirmation = addProfileImage.WriterPasswordConfirmation;
            w.WriterStatus = addProfileImage.WriterStatus;
            w.WriterAbout = addProfileImage.WriterAbout;
            writerManager.TAdd(w);


            return RedirectToAction("Index", "Dashboard");

        }










    }
}
