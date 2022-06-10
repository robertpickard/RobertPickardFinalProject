using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class AbstractRepository : Repository<Abstract>, IAbstractRepository
    {
        private readonly ApplicationDbContext _db;
        public AbstractRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetAbstractListForDropDown()
        {
            return _db.Abstract.Select(i => new SelectListItem()
            {
                Text = i.Title,
                Value = i.Id.ToString()
            });
        }

        public void Update(Abstract abstractObject)
        {
            var objFromDb = _db.Abstract.FirstOrDefault(s => s.Id == abstractObject.Id);

            objFromDb.AuthorId = abstractObject.AuthorId;
            objFromDb.Title = abstractObject.Title;
            objFromDb.Approved = abstractObject.Approved;
            objFromDb.ReviewDate = abstractObject.ReviewDate;
            if (abstractObject.DocPath != null)
            {
                objFromDb.DocPath = abstractObject.DocPath;
            }

            _db.SaveChanges();
        }
    }
}
