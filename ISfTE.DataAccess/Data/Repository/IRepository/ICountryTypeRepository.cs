using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface ICountryTypeRepository : IRepository<CountryType>
    {
        IEnumerable<SelectListItem> GetCountryTypeListForDropDown();
        void Update(CountryType countryType);
    }
}
