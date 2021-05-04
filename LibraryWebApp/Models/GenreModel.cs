using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class GenreModel
    {
        public int GenreID { get; set; }
        [Required]
        public bool IsFiction { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Name { get; set; }
    }
}