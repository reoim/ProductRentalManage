using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{


    public class MoviesController : Controller
    {
        // GET: Movies

        public ViewResult Index()
        {
            var moives = this.GetMovies();
            return View(moives);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie> { new Movie() { Id = 1, Name = "Shrek" }, new Movie() { Id = 2, Name = "Wall-e" } };
        }
    }
}