using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CesiAPP.Models;
using CesiAPP.ViewModels;

namespace CesiAPP.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
        };

            //NE PAS FAIRE car vieux
            /*
            ViewData["Movie"] = movie;
            ViewBag.Movie = movie;
            */
            
            return View(viewModel);

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        /*
        //Configs dans routeConfig.cs , ici c'est "id" qui existe
        public ActionResult Edit(int id)
        {
            return Content("Id= " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }*/

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        // Il existe aussi min, max, minlength, maxlength, int, float, guid

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}