using MVCDayOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDayOne.Controllers
{
    public class homeController : Controller
    {
        // Get verb
        public ViewResult index()
        {
            return View();
        }

        #region MyRegion
        //post verb
        [HttpPost] // when form method is post 
        public ViewResult index(int id, string name, int age)
        {
            return View();
        }

        #endregion

        #region MyRegion
        //public ViewResult add(int id, string name, int age)
        //{
        //    // Dictionary

        //    ViewData["id"] = id;
        //    ViewData["name"] = name;
        //    ViewData["age"] = age;

        //    return View();
        //} 
        #endregion

        public ViewResult add(studentdata sd)
        {
            return View(sd);
        }

    }
}