using ISfTE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface IAbstractRatingRepository : IRepository<AbstractRating>
    {
        int RatingCount(int id);
        string AvgRating(int id);
        void Update(AbstractRating abstractRating);
    }
}
