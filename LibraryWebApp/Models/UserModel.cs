using LibraryCommon;
using LibraryWebApp.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryWebApp.Models
{
    public class UserModel : BaseModel
    {
        public int UserID { get; set; }
        
        [Required]
        [MaxLength(100,ErrorMessage ="Must be 100 characters or less.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage ="Use letters only.")]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Must be 100 characters or less.")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Must be 100 characters or less.")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Must be 100 characters or less.")]
        [RegularExpression("^((?=.*[a-z])(?=.*[A-Z])(?=.*\\d)).+$", ErrorMessage = "Must contain One Uppercase, One Lowercase and One number.")]
        public string Password { get; set; }

        public string RoleName { get; set; }

        [Required]
        [Range(1, 3, ErrorMessage = "Must be 1-3")]
        public int RoleID_FK { get; set; }
        
        public string Salt { get; set; }
    }

}