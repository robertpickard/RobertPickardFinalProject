using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class GuestRepository : Repository<Guest>, IGuestRepository
    {
        private readonly ApplicationDbContext _db;
        public GuestRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Guest guest)
        {
            var objFromDb = _db.Guest.FirstOrDefault(s => s.Id == guest.Id);

            objFromDb.RegistrationId = guest.RegistrationId;
            objFromDb.FirstName = guest.FirstName;
            objFromDb.LastName = guest.LastName;
            objFromDb.Email = guest.Email;
            objFromDb.Relationship = guest.Relationship;

            _db.SaveChanges();
        }
    }
}
