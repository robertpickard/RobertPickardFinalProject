using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetUserListForDropDown()
        {
            return _db.ApplicationUser.Select(i => new SelectListItem()
            {
                Text = i.FullName,
                Value = i.Id.ToString()
            });
        }

        public void UpdateRole(string id, string status)
        {
            var userFromDb = _db.ApplicationUser.Find(id);

            if(userFromDb != null)
            {
                userFromDb.Status = status;
            }
            _db.SaveChanges();
        }
    }
}
