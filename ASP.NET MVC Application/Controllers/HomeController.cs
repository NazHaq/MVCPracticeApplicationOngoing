using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using ASP.NET_MVC_Application.Models;

namespace ASP.NET_MVC_Application.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            //Creating generic list
            List<SelectListItem> ObjList = new List<SelectListItem>()
            {
                new SelectListItem { Text = "Electrical", Value = "1" },
                new SelectListItem { Text = "Electronics", Value = "2" },
                new SelectListItem { Text = "Computer Science", Value = "3" },
                new SelectListItem { Text = "Mechanical", Value = "4" },
                new SelectListItem { Text = "Civil", Value = "5" },
                new SelectListItem { Text = "Information Technology", Value = "6" },

            };
            //Assigning generic list to ViewBag
            ViewBag.Locations = ObjList;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

       // [Authorize]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}