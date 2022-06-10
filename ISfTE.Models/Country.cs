using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISfTE.Models
{
    // This defines the columns for the Country model. It
    // also links to other tables through a foreign key.
    // It also make sure that required field are properly filled.
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CountryTypeId { get; set; }
        [ForeignKey("CountryTypeId")]
        public virtual CountryType CountryType { get; set; }
    }
}
