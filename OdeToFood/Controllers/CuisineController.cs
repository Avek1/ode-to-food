using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    //[Authorize] // can also be applied to the entire controller
    public class CuisineController : Controller
    {
        // GET: Cuisine
        //[Authorize] // can be applied at the Action level.
        //[Authorize(Roles="Admin")]  / example
        public ActionResult Search(string name = "french")  // this was Index().  this is tied to the ACTION parameter found in the RouteConfig
        {

            throw new Exception("Something terrible has happend!");

            //return View();  // don't need this right now.
          
            var message = Server.HtmlEncode(name);

            return Content(message);
            //return RedirectToAction("Index", "Home", new { name = name});
            //return RedirectToRoute("Default", new { controller = "Home", action = "About" });
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message=message, name="Scott"}, JsonRequestBehavior.AllowGet);
        }

       
    }
}