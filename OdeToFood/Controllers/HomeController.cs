using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = string.Format("{0}::{1} {2}", controller, action, id);

            ViewBag.Message = message;

            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            //ViewBag.Location = "Land of Cholas, USA";  
            // instead of the above, and to create an STRONGLY TYPED MODEL, create a model with appropriate properties 
            // ... and create an instance below and pass that model into the view. 

            var model = new AboutModel();
            model.Name = "Scott";
            model.Location = "Maryland, USA";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}