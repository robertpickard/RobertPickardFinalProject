using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.Models.ViewModels
{
    public class CountryVM
    {
        public Country Country { get; set; }
        public IEnumerable<SelectListItem> CountryTypeList { get; set; }
    }
}
