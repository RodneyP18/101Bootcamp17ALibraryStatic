using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class BookModel
    {
        public int BookID { get; set; } // primary key
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Boolean IsPaperback { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public int AuthorID_FK { get; set; }
        [Required]
        public int GenreID_FK { get; set; }
        [Required]
        public int PublisherID_FK { get; set; }
    }
}