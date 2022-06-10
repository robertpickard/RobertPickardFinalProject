using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class RegistrationRepository : Repository<Registration>, IRegistrationRepository
    {
        private readonly ApplicationDbContext _db;
        public RegistrationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Registration registration)
        {
            var objFromDb = _db.Registration.FirstOrDefault(s => s.Id == registration.Id);

            objFromDb.AttendeeId = registration.AttendeeId;
            objFromDb.StreetLine1 = registration.StreetLine1;
            objFromDb.StreetLine2 = registration.StreetLine2;
            objFromDb.TerritoryState = registration.TerritoryState;
            objFromDb.PostalCode = registration.PostalCode;
            objFromDb.CountryId = registration.CountryId;
            objFromDb.Fax = registration.Fax;
            objFromDb.TotalCost = registration.TotalCost;
            objFromDb.ArrivalTransport = registration.ArrivalTransport;
            objFromDb.ArrivalDateTime = registration.ArrivalDateTime;
            objFromDb.DepartTransport = registration.DepartTransport;
            objFromDb.DepartDateTime = registration.DepartDateTime;
            objFromDb.DietDisabilityNeeds = registration.DietDisabilityNeeds;
            objFromDb.Hotel = registration.Hotel;
            objFromDb.HotelInDate = registration.HotelInDate;
            objFromDb.HotelOutDate = registration.HotelOutDate;

            _db.SaveChanges();
        }
    }
}
