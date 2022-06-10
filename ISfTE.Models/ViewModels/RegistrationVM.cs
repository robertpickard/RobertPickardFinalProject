using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.Models.ViewModels
{
    public class RegistrationVM
    {
        public Registration Registration { get; set; }
        public Guest Guest { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
        public int SelectedCountry { get; set; }
    }
}
