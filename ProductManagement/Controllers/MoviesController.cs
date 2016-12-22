using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagement.Models;

namespace ProductManagement.Controllers
{
    using ProductManagement.ViewModels;

    public class MoviesController : Controller
    {
        public ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies

        public ViewResult Index()
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();
            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            return View(movie);
        }

        public ActionResult MovieForm()
        {
            var genres = _context.Genres.ToList();
            var viewModel = new MovieGenreViewModel {Genres = genres};
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return this.HttpNotFound();

            var viewModel = new MovieGenreViewModel { Movie = movie, Genres = this._context.Genres.ToList() };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
                
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.Genre = movie.Genre;
                movieInDb.Stock = movie.Stock;
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
       
    }
}