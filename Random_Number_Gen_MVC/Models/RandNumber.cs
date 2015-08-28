using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Random_Number_Gen_MVC.Models
{
    //in my quest to preserve the randomness of the originally gnerated array, I created a model that would
    //instantiate the array. My limited knowledge of the ASP.NET MVC framework prevented me from spend more 
    //time into making this work, so I decided to use ViewBags to move/bind data around.
    //I have always admired the MVC framework, and would like to continue learning about its implementation in ASP.NET
    public class RandNumber
    {
        public int[] randArray { get; set; }
    }
}