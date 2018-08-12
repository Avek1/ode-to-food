using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ReviewsController : Controller
    {
        [ChildActionOnly]
        public ActionResult BestReview()
        {
            var bestReview = from r in _reviews
                             orderby r.Rating descending
                             select r;
            return PartialView("_Review", bestReview.First());
        }
        // GET: Reviews
        public ActionResult Index()
        {
            var model =
                from r in _reviews
                orderby r.Country
                select r;

            return View(model);
        }

        // GET: /Reviews/Edit/5
        public ActionResult Edit(int id)
        {
            var review = _reviews.Single(r => r.Id == id);

            return View(review);
        }

        // POST: /Reviews/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var review = _reviews.Single(r => r.Id == id);
            if (TryUpdateModel(review))
            {
                // ..
                return RedirectToAction("Index");
            }
            return View(review);
        }




        // do i need to fill in the rest of the action methods?

        static List<RestaurantReview> _reviews = new List<RestaurantReview>
        {
            new RestaurantReview
            {
                Id = 1,
                Name = "Cinnamon Club",
                City = "London",
                Country = "UK",
                Rating = 10
            },

                     new RestaurantReview
            {
                Id = 2,
                Name = "Marrakesh",
                City = "D.C.",
                Country = "USA",
                Rating = 10
            },
                              new RestaurantReview
            {
                Id = 3,
                Name = "The House of Elliot",
                City = "Ghent",
                Country = "Belgium",
                Rating = 10
            }
        };
    }
}