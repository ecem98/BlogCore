using BusinessLayer.Conctrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogCore.Controllers
{
    public class AdminController : Controller
    {


        public IActionResult Index()
        {
          
            return View();
        }

        public PartialViewResult AdminNavbarPartial()
        {
            return PartialView();
        }



    }
}
