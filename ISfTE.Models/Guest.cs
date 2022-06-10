using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISfTE.Models
{
    public class Guest
    {
        // This defines the columns for the Guest model.
        // It also links to other tables through a foreign key.
        // It also make sure that required field are properly filled.
        [Key]
        public int Id { get; set; }
        [Required]
        public int RegistrationId { get; set; }
        [ForeignKey("RegistrationId")]
        public virtual Registration Registration { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Relationship { get; set; }

        [NotMapped]
        public string FullName { get { return FirstName + " " + LastName; } }
    }
}
