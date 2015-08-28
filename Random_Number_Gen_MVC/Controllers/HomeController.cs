using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Random_Number_Gen_MVC.Controllers
{
    public class HomeController : Controller
    {
        //these first 3 views simply return their respective Home views 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //There are two action methods to notice here:
        //listView: generates an array of 10,000 randomly "ordered" integers (from 1-10,000), 
        //and sends it to a partial view called _AjaxRand.  
        //gridView: also generates an array of 10,000 randomly "ordered" integers (from 1-10,000), 
        //and sends it to a partial view called _AjaxRandGrid.

        public PartialViewResult listView()
        {
            var randomVariable = new Random();
            int[] randomNumberArray = Enumerable.Range(1, 10000).OrderBy(randIn => randomVariable.Next()).ToArray();
            ViewBag.RandomNumbers = randomNumberArray;
            return PartialView("_AjaxRand");
            
            //*******About the following code********//
            //At one point, I really wanted to preserve the randomness of the array so I could switch
            //back and forward between ListView and GridView using AJAX. Unfortunately, time was limited, and the
            //approach I took didn't yield good results. I left the code here to show the way I approached it.
    
            //if (TempData["randArrayData"] == null)
            //{
            //    var randomVariable = new Random();
            //    int[] randomNumberArray = Enumerable.Range(1, 10000).OrderBy(randIn => randomVariable.Next()).ToArray();
            //    ViewBag.RandomNumbers = randomNumberArray;
            //    TempData["randArraySession"] = ViewBag.RandomNumbers;
            //    TempData.Keep();
            //}
            //else
            //{
            //    int[] randomNumberArray = (int[])TempData["randArraySession"];
            //    ViewBag.RandomNumbers = randomNumberArray;
            //}
            //****************************************//

        }

        public PartialViewResult gridView()
        {
            var randomVariable = new Random();
            int[] randomNumberArray = Enumerable.Range(1, 10000).OrderBy(randIn => randomVariable.Next()).ToArray();
            ViewBag.RandomNumbers = randomNumberArray;
            TempData["randArraySession"] = ViewBag.RandomNumbers;
            return PartialView("_AjaxRandGrid");
        }
    }
}