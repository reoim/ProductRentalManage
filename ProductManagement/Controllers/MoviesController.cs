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
        public ApplicationDbContext _context;

        public MoviesController()
        {
            this._context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            this._context.Dispose();
        }

        // GET: Movies

        public ViewResult Index()
        {
            var moives = this._context.Movies.ToList();
            return View(moives);
        }

        public ActionResult Details(int id)
        {
            var movie = this._context.Movies.SingleOrDefault(c => c.Id == id);
            return View(movie);
        }
       
    }
}