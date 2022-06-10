using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class CountryTypeRepository : Repository<CountryType>, ICountryTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CountryTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetCountryTypeListForDropDown()
        {
            return _db.CountryType.Select(i => new SelectListItem()
            {
                Text = i.Description,
                Value = i.Id.ToString()
            });
        }

        public void Update(CountryType countryType)
        {
            var objFromDb = _db.CountryType.FirstOrDefault(s => s.Id == countryType.Id);

            objFromDb.Description = countryType.Description;

            _db.SaveChanges();
        }
    }
}
