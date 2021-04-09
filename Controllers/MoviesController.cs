using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};
            var customers = new List<Customer>
            {
                new Customer{ Name = "John Smith", Id = 1 },
                new Customer{ Name = "Mary Williams", Id = 2 }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }
    }
}