using ISfTE.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface IGuestRepository : IRepository<Guest>
    {
        void Update(Guest guest);
    }
}
