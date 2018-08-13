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
        OdeToFoodDb _db = new OdeToFoodDb();

        public ActionResult Index()
        {
            var model = _db.Restaurants.ToList();

            return View(model);
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

        protected override void Dispose (bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}