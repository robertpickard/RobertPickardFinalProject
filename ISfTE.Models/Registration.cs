using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ISfTE.Models
{
    public class Registration
    {

        // This defines the columns for the Registration model.
        // It also links to other tables through a foreign key.
        // It also make sure that required field are properly filled.
        [Key]
        public int Id { get; set; }
        [Required]
        public string AttendeeId { get; set; }
        [ForeignKey("AttendeeId")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        [Required]
        [Display(Name ="Street Line 1")]
        public string StreetLine1 { get; set; }
        [Display(Name = "Street Line 2")]
        public string StreetLine2 { get; set; }
        [Display(Name = "Territory or State")]
        public string TerritoryState { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        [Required]
        [Display(Name = "Country")]
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }
        public string Fax { get; set; }
        [Required]
        [Display(Name = "Total Cost")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public double TotalCost { get; set; }

        //Can be edited later, 
        //possibly not entered at the time of registration
        [Display(Name ="Arrival Transport")]
        public string ArrivalTransport { get; set; }
        [Display(Name = "Arrival Date")]
        public DateTime? ArrivalDateTime { get; set; }
        [Display(Name = "Departure Transport")]
        public string DepartTransport { get; set; }
        [Display(Name = "Departure Date")]
        public DateTime? DepartDateTime { get; set; }
        [Display(Name = "Diet and/or Disability Needs")]
        public string DietDisabilityNeeds { get; set; }
        public string Hotel { get; set; }
        [Display(Name = "Hotel Check-In Date")]
        public DateTime? HotelInDate { get; set; }
        [Display(Name = "Hotel Check-Out Date")]
        public DateTime? HotelOutDate { get; set; }
    }
}
