using BusinessLayer.Conctrete;
using BusinessLayer.ValidationRules;
using ClosedXML.Excel;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BlogCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryRepository());

        
        public IActionResult ListCategories(int page=1)
        {
            var values = categoryManager.GetList().ToPagedList(page,8);
            return View(values);
        }

        
        public IActionResult MakeActive(int id)
        {
            var category = categoryManager.GetById(id);
            category.CategoryStatus = true;
            categoryManager.TUpdate(category);
            return RedirectToAction("ListCategories", "Category");
        }


        public IActionResult MakePasive(int id)
        {
            var category = categoryManager.GetById(id);
            category.CategoryStatus = false;
            categoryManager.TUpdate(category);
            return RedirectToAction("ListCategories", "Category");
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            FluentValidation.Results.ValidationResult results = categoryValidator.Validate(category);
            if (results.IsValid)
            {
                category.CategoryStatus = true;
                
                categoryManager.TAdd(category);

                return RedirectToAction("ListCategories", "Category");
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
        public IActionResult UpdateCategory(int id)
        {
            var categori = categoryManager.GetById(id);

            return View(categori);
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            var values = categoryManager.GetById(category.CategoryID);
            Console.WriteLine(values);
            Console.WriteLine(category);
            category.CategoryStatus =true;
            categoryManager.TUpdate(category);

            return RedirectToAction("ListCategories", "Category");
            
        }

        public IActionResult ExportStaticExelList()
        {
            var categoryList = categoryManager.GetList();
            using (var workbook = new XLWorkbook())
            {
                var worksheed = workbook.Worksheets.Add("Kategori Listesi");
                worksheed.Cell(1, 1).Value = "Kategori ID";
                worksheed.Cell(1, 2).Value = "Kategori Adı";
                worksheed.Cell(1, 3).Value = "Kategori Durumu";
                

                int BlogRowCount = 2;
                foreach (var item in categoryList)
                {
                    worksheed.Cell(BlogRowCount, 1).Value = item.CategoryID;
                    worksheed.Cell(BlogRowCount, 2).Value = item.CategoryName;
                    worksheed.Cell(BlogRowCount, 3).Value = item.CategoryStatus;
                    BlogRowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "KategoriListesi1.xlsx");
                }
            }

            //return View();
        }
    }
}
