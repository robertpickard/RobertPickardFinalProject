using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISfTE.Models
{
    public class AbstractRating
    {

        // This defines the columns for the AbstractRating model. It
        // also links to other tables through a foreign key.
        [Key]
        public int Id { get; set; }
        public int AbstractId { get; set; }
        [ForeignKey("AbstractId")]
        public virtual Abstract Abstract { get; set; }
        public string RaterId { get; set; }
        [ForeignKey("RaterId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        public int Mechanics { get; set; }
        public int Contribution { get; set; }

        [Display(Name = "Conference Fit")]
        public int ConferenceFit { get; set; }

        public string Comments { get; set; }

        public DateTime RatingDate { get; set; }

        [NotMapped]
        public string AvgRating { get { return (((double)Mechanics + (double)Contribution + (double)ConferenceFit)/3).ToString("0.0"); } }

        [NotMapped]
        public double AvgRatingDec { get { return (((double)Mechanics + (double)Contribution + (double)ConferenceFit) / 3); } }
    }
}
