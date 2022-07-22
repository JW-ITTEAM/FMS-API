using FMS_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FMS_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<SuperHero> SuperHeroes { get; set; }
    }
}
