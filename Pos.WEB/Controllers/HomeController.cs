using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pos.BLL;
using Pos.WEB.Models;

namespace Pos.WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Hello()
        {
          
            int nums = 100;
            for (int i = 1; i < 10; i++)
            {
                nums *= i;
            }
             
            string message = Messages.GetMessage();
            HelloWorldModel myModel = new HelloWorldModel();
            myModel.Count = nums;
            myModel.Message = message;
            return View(myModel);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}