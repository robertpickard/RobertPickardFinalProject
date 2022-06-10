using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface ICountryRepository : IRepository<Country>
    {
        IEnumerable<SelectListItem> GetCountryListForDropDown();
        IEnumerable<SelectListItem> GetCountries();
        void Update(Country country);
    }
}
