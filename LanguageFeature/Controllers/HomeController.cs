using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanguageFeature.Models;
namespace LanguageFeature.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello , We are going to learn various language features";
        }

        public ViewResult AutoProperty()
        {
            Product product = new Product();
            product.Name = "Redmi Note 5 Pro";
            string productName = product.Name;
            /*
             this is because the View method has an overload that accepts two String arguments and which has a different meaning to the overload that accepts a String and an object. 
             to avoid calling the wrong one, i explicitly cast the second argument
             */
            return View("Result", (object)string.Format("Product name is {0}", product.Name));
        }
    }
}