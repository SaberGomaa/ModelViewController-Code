using MVCDayOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDayOne.Controllers
{
    public class StudentController : Controller
    {

        // Ways to Send data
        //Route Data in url ? 
        //Post have body so can cary data // Form Data
        //Get doesn't hava body so data sent in URl // Query String 
        //priorty 1 FormData , 2 RouteData , 3 Querystring // send data from view to controller
        //model binder allows mapping HTTP request data with a model


        ITIContext context = new ITIContext();
        public ViewResult index()
        {
            return View();
        }
        public ViewResult add(Student s)
        {
            #region
            //int idQueryString = int.Parse(Request.QueryString["id"]);
            //int idRout = int.Parse(RouteData.Values["id"].ToString());
            //int idForm = int.Parse(Request.Form["id"]); 
            #endregion

            //viewBag store data like dynamic dictionary => key and value 
            ViewBag.id = s.Id;
            ViewBag.name = s.Name;
            ViewBag.age = s.Age;

            return View();
        }

        public ViewResult Dispaly()
        {
            List<Student> students = context.Students.ToList();
            ViewBag.st=students;      
            return View();
        }

    }
}