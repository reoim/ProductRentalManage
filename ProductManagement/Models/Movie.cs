using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagement.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Display (Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        [Display (Name = "Number in Stock")]
        public int? Stock { get; set; }

        
        public DateTime DateAdded { get; set; }

        
    }
}