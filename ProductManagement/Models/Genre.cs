using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManagement.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Genre
    {
        public int Id { get; set; }

        
        [Required]
        public string Name { get; set; }

    }
}