using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private readonly ApplicationDbContext _db;
        public CountryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCountryListForDropDown()
        {
            return _db.Country.Select(i => new SelectListItem()
            {
                Text = i.Name,
                Value = i.Id.ToString()
            });
        }

        public IEnumerable<SelectListItem> GetCountries()
        {
            return _db.Country.Select(i => new SelectListItem()
            {
                Text = i.CountryTypeId.ToString(),
                Value = i.Id.ToString()
            });
        }

        public void Update(Country country)
        {
            var objFromDb = _db.Country.FirstOrDefault(s => s.Id == country.Id);

            objFromDb.Name = country.Name;
            objFromDb.CountryTypeId = country.CountryTypeId;

            _db.SaveChanges();
        }
    }
}
