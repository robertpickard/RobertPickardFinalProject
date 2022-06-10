using System;
using System.Collections.Generic;
using System.Text;
using ISfTE.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ISfTE.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // These are used to define Data types and their get and set methods throughout this project

        public DbSet<Abstract> Abstract { get; set; }
        public DbSet<AbstractRating> AbstractRating { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<CountryType> CountryType { get; set; }
        public DbSet<Guest> Guest { get; set; }
        public DbSet<Registration> Registration { get; set; }
    }
}
