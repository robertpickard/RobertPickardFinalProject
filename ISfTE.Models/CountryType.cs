using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ISfTE.Models
{
    // This defines the columns for the CountryType model.
    // It also links to other tables through a foreign key.
    // It also make sure that required field are properly filled.
    public class CountryType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
