using MovieSubscription.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieSubscription.ViewModel;

namespace MovieSubscription.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult index()
        {
            Movie mv = new Movie() { Name = "Shrek!" };
            //var movies = new List<Movie>
            //{
            //    new Movie{ID=1,Name="Shrek" },
            //    new Movie{ID=2, Name="Wall-e" }
            //};
            MovieCollection movieCollection = new MovieCollection();
            //movieCollection.Movies = movies;
            return View(movieCollection);
        }
        // GET: Movies
        //public ActionResult Random()
        //{
        //    Movie mv = new Movie() { Name = "Shrek!" };
        //    var movies = new List<Movie>
        //    {
        //        new Movie{Name="Shrek" },
        //        new Movie{Name="Wall-e" }
        //    };
        //    var customers = new List<Customer>
        //    {
        //        new Customer{ Name="Customer 1"},
        //        new Customer{ Name="Customer 1"}
        //    };
        //    var viewmodel = new RandomViewModel
        //    {
        //        movie = mv,
        //        Customers = customers
        //    };
        //    return View(viewmodel);
        //}

        //public ActionResult Edit(int ID)
        //{
        //    return Content("id=" + ID);
        //}

        //public ActionResult Index(int? pageIndex, string sortby)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;

        //    if (!String.IsNullOrEmpty(sortby))
        //        sortby = "Name";

        //    return Content("sdfdf");
        //}


        //custom attributr routing
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"Year : {year} Month: {month}");
        }
    }
}