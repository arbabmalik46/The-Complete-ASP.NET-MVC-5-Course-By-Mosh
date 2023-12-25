using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movies = new Movies
            {
                ID = 1,
                Title = "James Bond"
            };
            //return View(movies);
            //return new ViewResult();
            //return Content("Hello World");
            //return HttpNotFound();
            return RedirectToAction("index","Home",new { page=1, sortBy = "Name"});
        }
    }
}