using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagement.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Genre { get; set; }

        public DateTime? ReleaseDate { get; set; }

        public int? Stock { get; set; }

        public DateTimeOffset? DateAdded { get; set; }

        
    }
}