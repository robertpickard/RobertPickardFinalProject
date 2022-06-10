using ISfTE.DataAccess.Data.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            Abstract = new AbstractRepository(_db);
            AbstractRating = new AbstractRatingRepository(_db);
            ApplicationUser = new ApplicationUserRepository(_db);
            Country = new CountryRepository(_db);
            CountryType = new CountryTypeRepository(_db);
            Guest = new GuestRepository(_db);
            Registration = new RegistrationRepository(_db);
        }

        public IAbstractRepository Abstract { get; private set; }
        public IAbstractRatingRepository AbstractRating { get; private set; }
        public IApplicationUserRepository ApplicationUser { get; private set; }
        public ICountryRepository Country { get; private set; }
        public ICountryTypeRepository CountryType { get; private set; }
        public IGuestRepository Guest { get; private set; }
        public IRegistrationRepository Registration { get; private set; }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
