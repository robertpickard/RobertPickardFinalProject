using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ISfTE.DataAccess;
using ISfTE.Models;

namespace ISfTE.Pages.Admin.Registration
{
    public class IndexModel : PageModel
    {
        private readonly ISfTE.DataAccess.ApplicationDbContext _context;

        public IndexModel(ISfTE.DataAccess.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Registration> Registration { get;set; }

        public async Task OnGetAsync()
        {
            Registration = await _context.Registration
                .Include(r => r.ApplicationUser)
                .Include(r => r.Country).ToListAsync();
        }
    }
}
