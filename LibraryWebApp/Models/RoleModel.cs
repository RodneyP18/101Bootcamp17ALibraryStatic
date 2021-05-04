using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class RoleModel
    {
        public int RoleID { get; set; }
        [Required]
        public string RoleName { get; set; }
    }
}