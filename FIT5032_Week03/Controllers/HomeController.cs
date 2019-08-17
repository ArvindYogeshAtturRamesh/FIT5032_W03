using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FIT5032_Week03.Models.HelloWorld;
using FIT5032_Week03.Models.Exercise;

namespace FIT5032_Week03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            //return View();
            Hello hello = new Hello();
            ViewBag.Message = hello.GetHello();
            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            ExampleDictionary exampleDictionary = new ExampleDictionary();
            exampleDictionary.Example();

            return View();
            


        }
    }
}