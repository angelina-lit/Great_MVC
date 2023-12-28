using GreatWeb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace GreatWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
