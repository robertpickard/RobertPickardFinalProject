using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISfTE.Models
{
    // This defines the columns for the ApplicationUser model. It
    // also make sure that required field are properly filled.
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Institution { get; set; }

        public string Title { get; set; }

        public string PreferredName { get; set; }


        public string Status { get; set; }

        [NotMapped]
        public string FullName { get { return Title + " " + FirstName + " " + LastName; } }
    }
} 

