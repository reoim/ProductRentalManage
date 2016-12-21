using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagement.ViewModels
{
    using ProductManagement.Models;

    public class MovieGenreViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }

    }
}