using ISfTE.DataAccess.Data.Repository.IRepository;
using ISfTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository
{
    public class AbstractRatingRepository: Repository<AbstractRating>, IAbstractRatingRepository
    {
        private readonly ApplicationDbContext _db;
        public AbstractRatingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public string AvgRating(int id)
        {
            var nullCheck = _db.AbstractRating.FirstOrDefault(a => a.AbstractId == id);

            if (nullCheck == null)
            {
                return "N/A";
            }

            var ConferenceFit = _db.AbstractRating.Where(a => a.AbstractId == id).Average(r => r.ConferenceFit);
            var Contribution = _db.AbstractRating.Where(a => a.AbstractId == id).Average(r => r.Contribution);
            var Mechanics = _db.AbstractRating.Where(a => a.AbstractId == id).Average(r => r.Mechanics);

            return (((double)Mechanics + (double)Contribution + (double)ConferenceFit) / 3).ToString("0.0");

        }

        public int RatingCount(int id)
        {
            return _db.AbstractRating.Where(r => r.AbstractId == id).Count();
        }

        public void Update(AbstractRating abstractRating)
        {
            var objFromDb = _db.AbstractRating.FirstOrDefault(s => s.Id == abstractRating.Id);

            objFromDb.AbstractId = abstractRating.AbstractId;
            objFromDb.RaterId = abstractRating.RaterId;
            objFromDb.ConferenceFit = abstractRating.ConferenceFit;
            objFromDb.Contribution = abstractRating.Contribution;
            objFromDb.Mechanics = abstractRating.Mechanics;
            objFromDb.Comments = abstractRating.Comments;
            objFromDb.RatingDate = abstractRating.RatingDate;

            _db.SaveChanges();
        }
    }
}
