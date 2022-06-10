using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface IAbstractRepository : IRepository<Abstract>
    {
        IEnumerable<SelectListItem> GetAbstractListForDropDown();
        void Update(Abstract abstractObject);
    }
}
