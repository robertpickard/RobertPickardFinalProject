using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISfTE.Models
{
    public class Abstract
    {

        // This defines the columns for the Abstract model. It
        // also links to other tables through a foreign key.
        [Key]
        public int Id { get; set; }
        public string AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name ="File")]
        public string DocPath { get; set; }
        [Required]
        public string Title { get; set; }
        public bool Approved { get; set; }
        public DateTime? ReviewDate { get; set; }
    }
}
