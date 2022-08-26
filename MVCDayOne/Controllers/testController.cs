using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDayOne.Controllers
{
    public class testController : Controller
    {
       public string home(int id , string name )
        {
            return "I am Saber" + id.ToString() + name;
        }
        public string Index()
        {
            return "Index";
        }

        public ViewResult about()
        {
            return View();
        }

        public ViewResult contact()
        {
            return View();
        }

    }
}