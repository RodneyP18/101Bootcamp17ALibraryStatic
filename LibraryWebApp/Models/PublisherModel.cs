using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class PublisherModel
    {
        public int PublisherID { get; set; } // Primary Key Property
        [Required]
        [MaxLength(100, ErrorMessage = "Must be 100 characters or less.")]
        public string Name { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Must be 100 characters or less.")]
        public string Address { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Must be 100 characters or less.")]
        public string City { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "Must be 100 characters or less.")]
        public string State { get; set; }
        [Required]
        public int Zip { get; set; }
    }
}