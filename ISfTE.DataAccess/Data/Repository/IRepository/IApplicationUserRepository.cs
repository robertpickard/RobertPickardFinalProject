using ISfTE.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.DataAccess.Data.Repository.IRepository
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        IEnumerable<SelectListItem> GetUserListForDropDown();

        void UpdateRole(string id, string status);
    }
}
