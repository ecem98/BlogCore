using BusinessLayer.Conctrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Controllers
{
    
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
       
        public IActionResult Index()
        {
            var list = blogManager.GetBlogsWithCategory();
            
            return View(list);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.id = id;
            var blog =blogManager.GetById(id);
           
            return View(blog);
        }

        public IActionResult BlogListAboutCategory(int id)
        {
            var kategori = categoryManager.GetById(id);
            var liste = blogManager.GetCategoiesBlogs(id);
            ViewBag.kategori = kategori.CategoryName;
            return View(liste);

        }


        public IActionResult WritersBlogList(int id)
        {
            var writer = writerManager.GetById(id);
            var blogList = blogManager.GetWritersAllBlogs(writer.WriterID);
            ViewBag.writerName = writer.WriterName;
            return View(blogList);

        }

        public IActionResult BlogListByUser()
        {
            var mail = User.Identity.Name;
            var userInfo = writerManager.FetchWriterByMail(mail);
            var blogList = blogManager.GetWritersAllBlogs(userInfo.WriterID);

            return View(blogList);

        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            ViewBag.categoryValues = categoryManager.GetCategoriesForDropDown();
            
            return View();

        }


        [HttpPost]
        public IActionResult BlogAdd(Blog blog)
        {
            BlogValidator blogValidator = new BlogValidator();
            FluentValidation.Results.ValidationResult results = blogValidator.Validate(blog);
            if (results.IsValid)
            {
                blog.BlogStatus = true;
                blog.BlogCreatingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                var mail = User.Identity.Name;
                var userInfo = writerManager.FetchWriterByMail(mail);
                blog.WriterID = userInfo.WriterID;
                blogManager.TAdd(blog);
                
                return RedirectToAction("BlogListByUser","Blog");
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

        [HttpGet]
        public IActionResult BlogUpdate(int id)
        {
            var blog = blogManager.GetById(id);
            ViewBag.categoryValues = categoryManager.GetCategoriesForDropDown();
            return View(blog);

        }

        [HttpPost]
        public IActionResult BlogUpdate(Blog blog)
        {
            var blogValue = blogManager.GetById(blog.BlogID);
            blog.BlogStatus = true;
            //blog.BlogCreatingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.BlogCreatingDate = DateTime.Parse(blogValue.BlogCreatingDate.ToString());
            var mail = User.Identity.Name;
            var userInfo = writerManager.FetchWriterByMail(mail);
            blog.WriterID = userInfo.WriterID;
            blogManager.TUpdate(blog);

           return RedirectToAction("BlogListByUser", "Blog");
           
        }

        public IActionResult BlogDell(int id)
        {
            var blog = blogManager.GetById(id);
            blogManager.TDelete(blog);

            return RedirectToAction("BlogListByUser", "Blog");

        }




    }
}
