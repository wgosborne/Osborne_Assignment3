using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Osborne_Assignment3.Models;

namespace Osborne_Assignment3.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Osborne_Assignment3.Models.Movie> Movie { get; set; }
        public DbSet<Osborne_Assignment3.Models.MovieActor> MovieActor { get; set; }

        //public DbSet<Movie> Movie { get; set; }
    }
}