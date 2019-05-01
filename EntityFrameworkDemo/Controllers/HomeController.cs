using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityFrameworkDemo.Models;

namespace EntityFrameworkDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FPDbContext myContext = new FPDbContext();
            var result = myContext.Celebrities.ToList();

            return View(result);
        }

        
    }
}