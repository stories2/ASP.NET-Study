using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        public string SayHello()
        {
            return "Hello!";
        }

        //public string Welcome(string name, int id = 1, int numTimes = 1)
        //{
        //    return HttpUtility.HtmlEncode("Hello " + name + ", numTimes is: " + numTimes + " #" + id);
        //}
        public ActionResult Welcome(string name, int id = 1, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.numTimes = numTimes;
            return View();
        }
    }
}